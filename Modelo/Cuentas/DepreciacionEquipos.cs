using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cuentas
{
    public class DepreciacionEquipos : IDBEntity
    {
        public int DepreciacionEquiposId { get; set; }
        public int EquiposOficinaID { get; set; }
        public EquiposOficina EquiposOficina { get; set; }
        public string Nombre { get; set; }
        public double Haber { get; set; }
        public double Acreedor { get; set; }
        public Fijo Fijo { get; set; }
    }
}
