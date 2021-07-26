using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cuentas
{
    public class PlazoCorto : IDBEntity
    {
        public int PlazoCortoId { get; set; }
        public List<IvaCobrado> IvaCobrados { get; set; }
        public List<ImpuestosPagar> ImpuestosPagars { get; set; }
        public List<InteresesPagar> InteresesPagars { get; set; }
        public List<Proveedor> Proveedores { get; set; }
        public List<DocumentosPagar> DocuementosPagars { get; set; }
        public List<IeesPagar> IeesPagars { get; set; }

    }
}
