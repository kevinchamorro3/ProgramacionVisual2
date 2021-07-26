using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cuentas
{
    public class PlazoLargo : IDBEntity
    {
        public int PlazoLargoId { get; set; }
        public List<PrestamosBancarios> PrestamosBancarios { get; set; }
    }
}
