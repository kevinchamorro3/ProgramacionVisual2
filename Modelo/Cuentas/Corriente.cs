using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cuentas
{
    public class Corriente : IDBEntity
    {
        public int CorrienteId { get; set; }
        public List<Caja> Cajas { get; set; }
        public List<Banco> Bancos { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<IvaPagado> IvasPagados { get; set; }
        public Inventario Inventario { get; set; }
        public CajaChica CajaChica { get; set; }
        public List<DocumentosCobrar> DocumentosCobrars { get; set; }
        public List<Suministros> Suminitros { get; set; }

    }
}
