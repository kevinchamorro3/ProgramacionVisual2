using Modelo;

using System.Collections.Generic;


namespace Escenarios
{
    public class Escenario
    {
        public enum ListaTipo { 
            Bancos,
            Cajas,
            CajaChica,
            Capital,
            Clientes,
            Corrientes,
            DepreciacionEdificio,
            DepreciacionEquipos,
            DocumentosCobrar,
            DocumentosPagar,
            Edificios,
            EquiposOficina,
            Fijos,
            IeesPagar,
            ImpuestoPagar,
            InteresPagar,
            Inventario,
            IvaCobrado,
            IvaPagado,
            Patrimonio,
            PlazoCorto,
            PlazoLargo,
            PrestamosBancarios,
            Proveedor,
            Suministros,
            Terrenos,
            UtilidadEjercicio,
            Vehiculos
        }

        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> datos;        

        public Escenario()
        {
            datos = new();
        }
    }
}
