using System;
using System.Text.RegularExpressions;

namespace CodeFormatter13.Dominio.CodeFormatter
{
    public class ServicoDeCodeFormatter : IServicoDeCodeFormatter
    {
        public Task<(string VariavesClasse, string CodigoValidacaoClasse)> FormatarClasseInformada(string segmento)
        {


            var variavesClasse = ObterVariaveisComBaseNoSegmento(segmento);
            var codigoValidacaoClasse = ObterCodigoDeValidacaoComBaseNoSegmento(segmento);

            return Task
               .FromResult(new ValueTuple<string, string>(variavesClasse,
               codigoValidacaoClasse));

        }

        private string ObterVariaveisComBaseNoSegmento(string segmento)
        {
            var classeFormadada = string.Empty;
            var listaDeCampos = ObterBlocosDeCampos(segmento);


            foreach (var item in listaDeCampos)
            {
                classeFormadada += $"var {item.Campo} = {item.PadChar};\n";
            }
         
            return classeFormadada;
        }

        private string ObterCodigoDeValidacaoComBaseNoSegmento(string segmento)
        {
            var validacaoFormatado = string.Empty;
            var listaDeCampos = ObterBlocosDeCampos(segmento);

            int index = 0;
            foreach (var item in listaDeCampos)
            {
                validacaoFormatado += $"Assert.Equal({item.Campo}, linhaArquivo.Substring({index}, {item.Posicao}));\n";
                index += item.Posicao;
            }

            return validacaoFormatado;
        }

        private List<CamposDeMapeamento> ObterBlocosDeCampos(string segmento)
        {
            const string alinhamentoLeft = "AlignMode.Left";
            const string CodigoCharZero = "ZeroChar";
            const string CodigoCharBranco = "CharBranco";

            var listaCampos = new List<CamposDeMapeamento>();

            var padraoBloco = @"\[FieldFixedLength\((\d+)\)\].*?(\[FieldAlign\((.*?)\)\])?.*?public\s+\w+\s+(\w+)";

            foreach (Match match in Regex.Matches(segmento, padraoBloco, RegexOptions.Singleline))
            {
                var campo = char.ToLower(match.Groups[4].Value[0]) + match.Groups[4].Value.Substring(1);
                var posicao = !string.IsNullOrEmpty(match.Groups[1].Value) 
                    ? match.Groups[1].Value 
                    : decimal.Zero.ToString();

                var alinhamento = !string.IsNullOrEmpty(match.Groups[3].Value)
                    ? match.Groups[3].Value.Split(',')[0] 
                    : alinhamentoLeft;
                
                var padChar = alinhamento == alinhamentoLeft 
                                   ? $".PadRight({posicao}, {CodigoCharBranco})"
                                   : $".PadLeft({posicao}, {CodigoCharZero})";

                listaCampos.Add(new CamposDeMapeamento
                {
                    Campo = campo,
                    Posicao = int.Parse(posicao),
                    Alinhamento = alinhamento,
                    PadChar = padChar

                });
            }

            return listaCampos;
        }

    }
}
