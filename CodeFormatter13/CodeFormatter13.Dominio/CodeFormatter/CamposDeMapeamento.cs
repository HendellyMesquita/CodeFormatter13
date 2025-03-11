using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFormatter13.Dominio.CodeFormatter
{
    public class CamposDeMapeamento
    {
        public string Campo { get; set; }
        public int Posicao { get; set; }
        public string Alinhamento { get; set; }
        public string PadChar { get; internal set; }
    }
}
