using Modelo;
using Modelo.Cuentas;
using System;
using System.Collections.Generic;

namespace Info
{
    public class CajasInfo
    {
        public static new string Publicar(IDBEntity entity)
        {
            var caja = (Caja)entity;
            return String.Format(
                "CajaId: {0} \n \t Nombre: {1} \n \t Debe: {2} \n \t Haber:{3}",
                caja.CajaId,
                caja.Nombre,
                caja.Debe,
                caja.Haber
            );
        }

        public static new string Publicar(IEnumerable<IDBEntity> entity)
        {
            var cajas = (List<Caja>)entity;
            string msj = "CajaId \t Nombre: \t Debe: \t Haber \n";
            foreach (var caja in cajas)
            {
                msj += String.Format(
                    "{0} \t \t {1} \t {2} \t {3} \n",
                    caja.CajaId,
                    caja.Nombre,
                    caja.Debe,
                    caja.Haber
                    );
            }
            return msj;
        }
    }
}
