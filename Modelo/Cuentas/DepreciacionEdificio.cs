using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cuentas
{
    public class DepreciacionEdificio : IDBEntity
    {
        public int DepreciacionEdificioId { get; set; }
        public int EdificioID { get; set; }
        public Edificio Edificio { get; set; }
        public string Nombre { get; set; }
        public double Haber { get; set; }
        public double Acreedor { get; set; }
        public Fijo Fijo { get; set; }
    }
}
