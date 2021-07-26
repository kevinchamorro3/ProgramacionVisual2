using Modelo;
using Modelo.Cuentas;
using System;
using System.Collections.Generic;
using static Escenarios.Escenario;

namespace Escenarios
{
    public class Escenario01 : Escenario, IEscenario
    {
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> Carga()
        {
            //datos bancos
            Banco banco1 = new(){Nombre = "Pichincha",Debe = 8704,Haber=5600,};
            Banco banco2 = new(){Nombre = "GYE",Debe = 16632,Haber = 448,};
            Banco banco3 = new(){Nombre = "Rumiñahui",Debe = 3360,Haber = 9330.77,};
            List<Banco> listaBancos = new() {banco1,banco2,banco3 };
            datos.Add(ListaTipo.Bancos, listaBancos);
            //datos caja
            Caja caja1 = new() {Nombre="Caja 1",Debe=16632,Haber= 16632,};
            Caja caja2 = new() {Nombre="Caja 2",Debe=3360,Haber= 3360 };
            Caja caja3 = new() {Nombre="Caja 3",Debe=4480,Haber= 0 };
            List<Caja> listaCajas = new() { caja1, caja2, caja3 };
            datos.Add(ListaTipo.Cajas,listaCajas);
            //datos cliente
            Cliente cliente1 = new() {Nombre="Pronaca S.A.",Debe=8000,Haber=0 };
            List<Cliente> listaClientes = new() { cliente1 };
            datos.Add(ListaTipo.Clientes, listaClientes);
            //datos iva pagado
            IvaPagado iva1 = new() { Nombre = "Gasolina", Debe = 1852 };
            IvaPagado iva2 = new() { Nombre = "Productos", Debe = 654 };
            IvaPagado iva3 = new() { Nombre = "Varios", Debe = 324 };
            List<IvaPagado> listaIvasPaga = new() {iva1,iva2,iva3 };
            datos.Add(ListaTipo.IvaPagado,listaIvasPaga);
            //datos invemntario
            Inventario inventario1 = new() { Nombre = "Inventario 1", Debe = 9000 };
            List<Inventario> listaInventario = new() {inventario1 };
            datos.Add(ListaTipo.Inventario, listaInventario);
            //datos caja chica
            CajaChica cajachica = new() { Nombre = "Caja chica", Debe = 200 };
            List<CajaChica> listacjachica = new() { cajachica };
            datos.Add(ListaTipo.CajaChica, listacjachica);
            //documentos por cobrar
            DocumentosCobrar documentosCobra1 = new() {Nombre="Documentos 1", Debe=11200,Haber=3360 };
            DocumentosCobrar documentosCobrar2 = new() {Nombre="Documentos 2", Debe=1792 };
            List<DocumentosCobrar> listadocCobra = new() { documentosCobra1, documentosCobrar2 };
            datos.Add(ListaTipo.DocumentosCobrar, listadocCobra);
            //datos suministros
            Suministros suministros = new() { Nombre = "Suministro 1", Debe = 200, Haber = 150 };
            List<Suministros> listaSuministros = new() { suministros };
            datos.Add(ListaTipo.Suministros, listaSuministros);
            //Corrientes
            Corriente corrient1 = new Corriente {
                Bancos = listaBancos,
                Cajas = listaCajas,
                Clientes = listaClientes,
                IvasPagados = listaIvasPaga,
                Inventario = inventario1,
                CajaChica = cajachica,
                DocumentosCobrars = listadocCobra,
                Suminitros=listaSuministros
                
            };
            List<Corriente> listaCorrientes = new() { corrient1 };
            datos.Add(ListaTipo.Corrientes, listaCorrientes);

            //terrenos
            Terreno terreno1 = new() { Nombre = "Terreno Mitad del Mundo", Debe=10000};
            List<Terreno> listaTerrenos = new() { terreno1 };
            datos.Add(ListaTipo.Terrenos, listaTerrenos);
            //Edificios
            Edificio edificio1 = new() {Nombre="Edificio Solamar",Debe=130000 };
            List<Edificio> listEdificios = new() { edificio1 };
            datos.Add(ListaTipo.Edificios, listEdificios);
            //depreciacion
            DepreciacionEdificio dpEdificio = new() {Nombre="Dep Edificio Solamar",Edificio=edificio1, Haber=541.67 };
            List<DepreciacionEdificio> listdepEdi = new() { dpEdificio };
            datos.Add(ListaTipo.DepreciacionEdificio,listdepEdi);
            //equipos de oficina
            EquiposOficina eqOf = new() { Nombre = "Varios", Debe = 8000 };
            List<EquiposOficina> listaEqui = new() { eqOf };
            datos.Add(ListaTipo.EquiposOficina, listaEqui);
            //depreciacion equipos
            DepreciacionEquipos depOfi = new() { Nombre = "Dep Equipos Varios", EquiposOficina = eqOf, Haber = 133 };
            List<DepreciacionEquipos> listadepOf = new() { depOfi };
            datos.Add(ListaTipo.DepreciacionEquipos, listadepOf);
            //vehiculos
            Vehiculo vehiculo1 = new() { Nombre = "Renault", Debe = 2000 };
            List<Vehiculo> listavehi = new() { vehiculo1 };
            datos.Add(ListaTipo.Vehiculos, listavehi);
            ///fijos
            Fijo fijo1 = new() {
                Terrenos=listaTerrenos,
                Edificios=listEdificios,
                EquiposOficinas=listaEqui,
                Vehiculos=listavehi
            };
            List<Fijo> listafijo = new() { fijo1 };
            datos.Add(ListaTipo.Fijos, listafijo);


            //IvaCobrado
            IvaCobrado ivaCobrado = new() { Nombre="Iva Cobrado",Debe=600,Haber=4356 };
            List<IvaCobrado> listivaCobrados = new() { ivaCobrado };
            datos.Add(ListaTipo.IvaCobrado, listivaCobrados);
            //impuestos por pagar
            ImpuestosPagar impuestosPagar = new() { Nombre = "Impuestos pagar", Haber = 3000 };
            List<ImpuestosPagar> listimpuestosPagars = new() { impuestosPagar };
            datos.Add(ListaTipo.ImpuestoPagar, listimpuestosPagars);
            //intereses por pagar
            InteresesPagar interesesPagar = new() { Nombre = "Intereses Pagar 2021", Haber = 9282 };
            List<InteresesPagar> listinteresesPagars = new() { interesesPagar };
            datos.Add(ListaTipo.InteresPagar, listinteresesPagars);
            //Proveedores
            Proveedor proveedor = new() { Nombre = "Pronaca S.A.", Haber = 30000 };
            List<Proveedor> listproveedors = new() { proveedor };
            datos.Add(ListaTipo.Proveedor, listproveedors);
            //documento por pagar
            DocumentosPagar documentosPagar = new() { Nombre = "Doc Pagar 2021", Haber = 1120 };
            List<DocumentosPagar> listdocumentosPagars = new() { documentosPagar };
            datos.Add(ListaTipo.DocumentosPagar, listdocumentosPagars);
            //iees por pagar
            IeesPagar ieesPagar = new() { Nombre = "IESS 2021", Haber = 339.63 };
            List<IeesPagar> listieesPagars = new() { ieesPagar };
            datos.Add(ListaTipo.IeesPagar, listieesPagars);
            //corto plazo
            PlazoCorto plazoCorto1 = new() {
                IvaCobrados = listivaCobrados,
                ImpuestosPagars = listimpuestosPagars,
                InteresesPagars = listinteresesPagars,
                Proveedores = listproveedors,
                DocuementosPagars = listdocumentosPagars,
                IeesPagars=listieesPagars
            };
            List<PlazoCorto> listaPlazocorto = new() { plazoCorto1 };
            datos.Add(ListaTipo.PlazoCorto, listaPlazocorto);

            //prestamos bancarios
            PrestamosBancarios prestamosBancarios = new() { Nombre = "Prestamos Banco Pichicncha", Haber = 100000 };
            List<PrestamosBancarios> listprestamosBancarios = new() { prestamosBancarios };
            datos.Add(ListaTipo.PrestamosBancarios, listprestamosBancarios);
            //largo plazo
            PlazoLargo plazolargo = new()
            {
                PrestamosBancarios=listprestamosBancarios                
            };
            List<PlazoLargo> listaPlazolargo = new() { plazolargo };
            datos.Add(ListaTipo.PlazoLargo, listaPlazolargo);

            //capitak
            Capital capital = new() { Nombre = "Capital total", Haber = 122500, };
            List<Capital> listcapitals = new() { capital };
            datos.Add(ListaTipo.Capital, listcapitals);
            //utilidad ejerccioo
            UtilidadEjercicio utilidadEjercicio = new() { Nombre = "Utilidad 1", Haber = 12404, };
            List<UtilidadEjercicio> listutilidadEjercicios = new() { utilidadEjercicio };
            datos.Add(ListaTipo.UtilidadEjercicio, listutilidadEjercicios);
            //patrimonio
            Patrimonio patrimonio = new() {
                Capital=capital,
                UtilidadEjercicio=utilidadEjercicio
            };
            List<Patrimonio> listpatrimonios = new() { patrimonio };
            datos.Add(ListaTipo.Patrimonio,listpatrimonios);

            // Retorna el diccionario 
            return datos;
        }

    }
}
