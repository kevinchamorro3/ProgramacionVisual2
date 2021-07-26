using Modelo;
using Modelo.Cuentas;
using System;
using System.Collections.Generic;

namespace Info
{
    public class BancosInfo
    {
        public static new string Publicar(IDBEntity entity)
        {
            var banco = (Banco)entity;
            return String.Format(
                "BancoId: {0} \n \t Nombre: {1} \n \t Debe: {2} \n \t Haber:{3}",
                banco.BancoId,
                banco.Nombre,
                banco.Debe,
                banco.Haber
            );
        }

        public static new string Publicar(IEnumerable<IDBEntity> entity)
        {
            var bancos = (List<Banco>)entity;
            string msj = "BancoId \t Nombre: \t Debe: \t Haber \n";
            foreach (var banco in bancos)
            {
                msj += String.Format(
                    "{0} \t \t {1} \t {2} \t {3} \n",
                    banco.BancoId,
                    banco.Nombre,
                    banco.Debe,
                    banco.Haber
                    );
            }
            return msj;
        }
    }
}
