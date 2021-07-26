using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cuentas
{
    public class Proveedor : IDBEntity
    {
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public double Debe { get; set; }
        public double Haber { get; set; }
        public double Acreedor { get; set; }
        public double Deudor { get; set; }
        public int PlazoCortoID { get; set; }
        public PlazoCorto PlazoCorto { get; set; }
    }
}
