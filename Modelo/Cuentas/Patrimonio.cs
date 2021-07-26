using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cuentas
{
    public class Patrimonio : IDBEntity
    {
        public int PatrimonioID { get; set; }
        public Capital Capital { get; set; }
        public UtilidadEjercicio UtilidadEjercicio { get; set; }
    }
}
