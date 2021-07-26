using Escenarios;
using Modelo.Cuentas;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Escenarios.Escenario;

namespace ProyectoFinalPG2_Chamorro
{
    public class EscenarioControl
    {
        public void Grabar( IEscenario escenario )
        {
            var datos = escenario.Carga();

            using (var db = new CuentasContext())
            {
                // Reiniciamos la base de datos
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                // Insertamos los datos
                db.corrientes.AddRange((List<Corriente>)datos[ListaTipo.Corrientes]);
                db.bancos.AddRange   ((List<Banco>)  datos[ListaTipo.Bancos]  );
                db.cajas.AddRange   ((List<Caja>)  datos[ListaTipo.Cajas]  );
                db.clientes.AddRange   ((List<Cliente>)  datos[ListaTipo.Clientes]  );
                db.ivaPagados.AddRange   ((List<IvaPagado>)  datos[ListaTipo.IvaPagado]  );
                db.inventarios.AddRange   ((List<Inventario>)  datos[ListaTipo.Inventario]  );
                db.cajaChicas.AddRange   ((List<CajaChica>)  datos[ListaTipo.CajaChica]  );
                db.documentosCobrars.AddRange   ((List<DocumentosCobrar>)  datos[ListaTipo.DocumentosCobrar]  );
                db.suministros.AddRange   ((List<Suministros>)  datos[ListaTipo.Suministros]  );
                db.fijos.AddRange((List<Fijo>)datos[ListaTipo.Fijos]);
                db.terrenos.AddRange((List<Terreno>)datos[ListaTipo.Terrenos]);
                db.edificios.AddRange((List<Edificio>)datos[ListaTipo.Edificios]);
                db.depreciacionEdificios.AddRange((List<DepreciacionEdificio>)datos[ListaTipo.DepreciacionEdificio]);
                db.equiposOficinas.AddRange((List<EquiposOficina>)datos[ListaTipo.EquiposOficina]);
                db.depreciacionEquipos.AddRange((List<DepreciacionEquipos>)datos[ListaTipo.DepreciacionEquipos]);
                db.vehiculos.AddRange((List<Vehiculo>)datos[ListaTipo.Vehiculos]);
                db.plazoCortos.AddRange((List<PlazoCorto>)datos[ListaTipo.PlazoCorto]);
                db.ivaCobrados.AddRange((List<IvaCobrado>)datos[ListaTipo.IvaCobrado]);
                db.impuestosPagars.AddRange((List<ImpuestosPagar>)datos[ListaTipo.ImpuestoPagar]);
                db.interesesPagars.AddRange((List<InteresesPagar>)datos[ListaTipo.InteresPagar]);
                db.proveedors.AddRange((List<Proveedor>)datos[ListaTipo.Proveedor]);
                db.documentosPagars.AddRange((List<DocumentosPagar>)datos[ListaTipo.DocumentosPagar]);
                db.ieesPagars.AddRange((List<IeesPagar>)datos[ListaTipo.IeesPagar]);
                db.plazoLargos.AddRange((List<PlazoLargo>)datos[ListaTipo.PlazoLargo]);
                db.prestamosBancarios.AddRange((List<PrestamosBancarios>)datos[ListaTipo.PrestamosBancarios]);
                db.patrimonios.AddRange((List<Patrimonio>)datos[ListaTipo.Patrimonio]);
                db.capitals.AddRange((List<Capital>)datos[ListaTipo.Capital]);
                db.utilidadEjercicios.AddRange((List<UtilidadEjercicio>)datos[ListaTipo.UtilidadEjercicio]);
                // Genera la persistencia
                db.SaveChanges();
                Console.WriteLine("-----------------------Datos Guardados con éxito------------------------");
            }
        }
    }
}
