using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Tipo
    {
        public int ID { get; set; }
        public string TipoIncidente { get; set; }
        public Tipo(string tipoIn)
        {
            TipoIncidente = tipoIn;
        }
        public override string ToString()
        {
            return TipoIncidente;
        }
    }
}
