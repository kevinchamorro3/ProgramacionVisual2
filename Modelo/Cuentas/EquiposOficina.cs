﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cuentas
{
    public class EquiposOficina : IDBEntity
    {
        public int EquiposOficinaId { get; set; }
        public int DepreciacionEquiposId { get; set; }
        public DepreciacionEquipos DepreciacionEquipos { get; set; }
        public string Nombre { get; set; }
        public double Debe { get; set; }
        public double Haber { get; set; }
        public double Acreedor { get; set; }
        public double Deudor { get; set; }
        public int FijoID { get; set; }
        public Fijo Fijo { get; set; }
    }
}
