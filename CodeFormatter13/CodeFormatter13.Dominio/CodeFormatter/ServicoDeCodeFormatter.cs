using System.Text.RegularExpressions;

namespace CodeFormatter13.Dominio.CodeFormatter
{
    public class ServicoDeCodeFormatter : IServicoDeCodeFormatter
    {
        private const string AlinhamentoLeft = "AlignMode.Left";
        private const string CodigoCharZero = "ZeroChar";
        private const string CodigoCharBranco = "CharBranco";
        private int posicaoAtual = default;

        public Task<(string VariavesClasse, string CodigoValidacaoClasse, string VariaveisRetorno)> FormatarClasseInformada(string segmento)
        {
            try
            {
                var variavesRemessa = string.Empty;
                var validadorClasse = string.Empty;
                var variavesRetorno = string.Empty;

                var listaDeCampos = ObterBlocosDeCampos(segmento);

                foreach (var linhaMap in listaDeCampos)
                {
                    variavesRemessa = ObterVariaveisComBaseNoSegmento(segmento, variavesRemessa, linhaMap);
                    variavesRetorno = ObterVariaveisComBaseNoSegmentoParaRetonto(segmento, variavesRetorno, linhaMap);
                    validadorClasse = ObterCodigoDeValidacaoComBaseNoSegmento(segmento, validadorClasse, linhaMap);
                    posicaoAtual += linhaMap.Posicao;

                }
                posicaoAtual = default;

                return Task
                   .FromResult(new ValueTuple<string, string, string>(variavesRemessa,
                   validadorClasse, variavesRetorno));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private string ObterVariaveisComBaseNoSegmento(string segmento, string variavesRemessa, CamposDeMapeamento linhaMap)
        {

            return variavesRemessa += $"var {linhaMap.Campo} = {linhaMap.ValorAtribuido}{linhaMap.PadChar};\n";

        }

        private string ObterVariaveisComBaseNoSegmentoParaRetonto(string segmento, string variavesRetorno, CamposDeMapeamento linhaMap)
        {

            return variavesRetorno += $"var {linhaMap.Campo} = registroSegmento.Conteudo.Substring({posicaoAtual}, {linhaMap.Posicao});\n";

        }

        private string ObterCodigoDeValidacaoComBaseNoSegmento(string segmento, string validadorClasse, CamposDeMapeamento linhaMap)
        {

            return validadorClasse += $"Assert.Equal({linhaMap.Campo}, linhaArquivo.Substring({posicaoAtual}, {linhaMap.Posicao}));\n";

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