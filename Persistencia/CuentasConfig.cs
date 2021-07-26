using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;

namespace Persistencia
{
    public class CuentasConfig
    {
        static string PersistenciaDestino;
        static string StringConnection;

        static CuentasConfig()
        {
            if (String.IsNullOrEmpty(StringConnection))
            {
                //lectura de parametros del sistema
                PersistenciaDestino = ConfigurationManager.AppSettings["PersistenciaDestino"].ToString();
                StringConnection = ConfigurationManager.ConnectionStrings[PersistenciaDestino].ToString();
                //Debug
                Console.WriteLine(PersistenciaDestino + " " + StringConnection);
            }            
        }

        static public void ContextOptions(DbContextOptionsBuilder optionsBuilder)
        {
            Console.WriteLine(PersistenciaDestino);
            switch (PersistenciaDestino)
            {
                case "SqlServerProyecto":
                    optionsBuilder.UseSqlServer(StringConnection);
                    break;
                case "PostgresProyecto":
                    optionsBuilder.UseNpgsql(StringConnection);
                    break;
                case "MemoryProyecto":
                    optionsBuilder.UseInMemoryDatabase(StringConnection);
                    break;
                default:
                    break;
            }
        }
                
    }
}
