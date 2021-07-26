using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cuentas
{
    public class Fijo : IDBEntity
    {
        public int FijoId { get; set; }
        public List<Terreno> Terrenos { get; set; }
        public List<Edificio> Edificios { get; set; } 
        public List<EquiposOficina> EquiposOficinas { get; set; }

        public List<Vehiculo> Vehiculos { get; set; }
    }
}
