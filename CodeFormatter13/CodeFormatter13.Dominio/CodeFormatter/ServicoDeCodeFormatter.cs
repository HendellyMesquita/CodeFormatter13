using System.Text.RegularExpressions;

namespace CodeFormatter13.Dominio.CodeFormatter
{
    public class ServicoDeCodeFormatter : IServicoDeCodeFormatter
    {
        private const string AlinhamentoLeft = "AlignMode.Left";
        private const string CodigoCharZero = "ZeroChar";
        private const string CodigoCharBranco = "CharBranco";

        public Task<(string VariavesClasse, string CodigoValidacaoClasse, string VariaveisRetorno)> FormatarClasseInformada(string segmento)
        {


            var variavesClasse = ObterVariaveisComBaseNoSegmento(segmento);
            var codigoValidacaoClasse = ObterCodigoDeValidacaoComBaseNoSegmento(segmento);
            var variavesRetorno = ObterVariaveisComBaseNoSegmentoParaRetonto(segmento);

            return Task
               .FromResult(new ValueTuple<string, string, string>(variavesClasse,
               codigoValidacaoClasse, variavesRetorno));

        }

        private string ObterVariaveisComBaseNoSegmento(string segmento)
        {
            var classeFormadada = string.Empty;
            var listaDeCampos = ObterBlocosDeCampos(segmento);


            foreach (var item in listaDeCampos)
            {
                classeFormadada += $"var {item.Campo} = {item.ValorAtribuido}{item.PadChar};\n";
            }

            return classeFormadada;
        }
        
        private string ObterVariaveisComBaseNoSegmentoParaRetonto(string segmento)
        {
            var classeFormadada = string.Empty;
            var listaDeCampos = ObterBlocosDeCampos(segmento);
            var index = 0;

            foreach (var item in listaDeCampos)
            {
                classeFormadada += $"var {item.Campo} = segmento.Conteudo.Substring({index}, {item.Posicao}));\n";
                index += item.Posicao;
            }

            return classeFormadada;
        }

        private string ObterCodigoDeValidacaoComBaseNoSegmento(string segmento)
        {
            var validacaoFormatado = string.Empty;
            var listaDeCampos = ObterBlocosDeCampos(segmento);
            var index = 0;

            foreach (var item in listaDeCampos)
            {
                validacaoFormatado += $"Assert.Equal({item.Campo}, linhaArquivo.Substring({index}, {item.Posicao}));\n";
                index += item.Posicao;
            }

            return validacaoFormatado;
        }

        private List<CamposDeMapeamento> ObterBlocosDeCampos(string segmento)
        {
            

            var listaCampos = new List<CamposDeMapeamento>();

            var padraoBloco = @"\[FieldFixedLength\((\d+)\)\].*?public\s+\w+\s+(\w+)(?:\s*=\s*([^;]+))?;";

            foreach (Match match in Regex.Matches(segmento, padraoBloco, RegexOptions.Singleline))
            {
                var campo = char.ToLower(match.Groups[2].Value[0]) + match.Groups[2].Value.Substring(1);
                var valorAtribuido = match.Groups[3].Success ? match.Groups[3].Value.Trim() : string.Empty;
                var posicao = !string.IsNullOrEmpty(match.Groups[1].Value)
                    ? match.Groups[1].Value
                    : decimal.Zero.ToString();

                var alinhamento = ExtrairAlignMode(match.Value);

                var padChar = alinhamento == AlinhamentoLeft
                                   ? $".PadRight({posicao}, {CodigoCharBranco})"
                                   : $".PadLeft({posicao}, {CodigoCharZero})";

                listaCampos.Add(new CamposDeMapeamento
                {
                    Campo = campo,
                    ValorAtribuido = valorAtribuido,
                    Posicao = int.Parse(posicao),
                    Alinhamento = alinhamento,
                    PadChar = padChar

                });
            }

            return listaCampos;
        }


        private string ExtrairAlignMode(string matchValue)
        {
            var padraoAlignMode = @"FieldAlign\((.*?)\)";

            var alignModeMatch = Regex.Match(matchValue, padraoAlignMode);

            if (alignModeMatch.Success)
            {
                return alignModeMatch.Groups[1].Value.Split(',')[0];
            }

            return AlinhamentoLeft;
        }
    }
}