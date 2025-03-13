using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFormatter13.Dominio.CodeFormatter
{
    public interface IServicoDeCodeFormatter
    {
        Task<(string VariavesClasse, string CodigoValidacaoClasse, string VariaveisRetorno)> FormatarClasseInformada(string segmento);
    }
}
