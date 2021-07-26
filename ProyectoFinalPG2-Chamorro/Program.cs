using Escenarios;
using Info;
using Persistencia;
using System;
using System.Linq;

namespace ProyectoFinalPG2_Chamorro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Código para crear el escenario 1
            Escenario01 escenario = new Escenario01();
            EscenarioControl control = new EscenarioControl();
            control.Grabar(escenario);
            //impresionde entidad bancos
            using (var db = new CuentasContext())
            {
                //traemos los bancos
                var bancos = db.bancos.ToList();
                //usamos las funciones para mostrar los datos
                Console.WriteLine(BancosInfo.Publicar(bancos));
                //usaremos la sobrecarga del metodo publicar para mostrar una sola cuenta
                var banco = db.bancos.Where(ban => ban.Nombre == "Pichincha").Single();
                Console.WriteLine(BancosInfo.Publicar(banco));
            }
        }
    }
}
