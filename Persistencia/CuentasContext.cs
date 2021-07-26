using Microsoft.EntityFrameworkCore;
using Modelo.Cuentas;
using System;

namespace Persistencia
{
    public class CuentasContext: DbContext
    {
        // Clases tipo entidad 
        public DbSet<Banco> bancos { get; set; }
        public DbSet<Caja> cajas { get; set; }
        public DbSet<CajaChica> cajaChicas { get; set; }
        public DbSet<Capital> capitals { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<DocumentosPagar> documentosPagars { get; set; }
        public DbSet<DocumentosCobrar> documentosCobrars { get; set; }
        public DbSet<Corriente> corrientes { get; set; }
        public DbSet<DepreciacionEdificio> depreciacionEdificios { get; set; }
        public DbSet<DepreciacionEquipos> depreciacionEquipos { get; set; }
        public DbSet<Edificio> edificios { get; set; }
        public DbSet<EquiposOficina> equiposOficinas { get; set; }
        public DbSet<Fijo> fijos { get; set; }
        public DbSet<IeesPagar> ieesPagars { get; set; }
        public DbSet<ImpuestosPagar> impuestosPagars { get; set; }
        public DbSet<InteresesPagar> interesesPagars { get; set; }
        public DbSet<Inventario> inventarios { get; set; }
        public DbSet<IvaCobrado> ivaCobrados { get; set; }
        public DbSet<IvaPagado> ivaPagados { get; set; }
        public DbSet<Patrimonio> patrimonios { get; set; }
        public DbSet<PlazoCorto> plazoCortos { get; set; }
        public DbSet<PlazoLargo> plazoLargos { get; set; }
        public DbSet<PrestamosBancarios> prestamosBancarios{ get; set; }
        public DbSet<Proveedor> proveedors { get; set; }
        public DbSet<Suministros> suministros{ get; set; }
        public DbSet<Terreno> terrenos { get; set; }
        public DbSet<UtilidadEjercicio> utilidadEjercicios { get; set; }
        public DbSet<Vehiculo> vehiculos { get; set; }

        // Constructor vacio
        public CuentasContext() : base()
        {

        }

        // Constructor para pasar la conexión al padre
        public CuentasContext(DbContextOptions<CuentasContext> opciones)
            : base(opciones)
        {

        }
        // Se mantiene para la creación de la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                CuentasConfig.ContextOptions(optionsBuilder);
            }
        }

        // Configuración del modelo de objetos tipo entidad
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Corrientes
            modelBuilder.Entity<Corriente>()
                .HasMany(cor => cor.Bancos)
                .WithOne(ban => ban.Corriente)
                .HasForeignKey(ban => ban.CorrienteID);
            //relacion corriente con cajas
            modelBuilder.Entity<Corriente>()
                .HasMany(cor => cor.Cajas)
                .WithOne(caj=>caj.Corriente)
                .HasForeignKey(caj=>caj.CorrienteID);
            //relacion corriente con caja chica
            modelBuilder.Entity<Corriente>()
                .HasOne(cor => cor.CajaChica)
                .WithOne(caj => caj.Corriente)
                .HasForeignKey<CajaChica>(caj => caj.CorrienteID);
            //relacion corriente con clientes
            modelBuilder.Entity<Corriente>()
               .HasMany(cor => cor.Clientes)
               .WithOne(cli=>cli.Corriente)
               .HasForeignKey(cli=>cli.CorrienteID);
            //correinte con iva pagado
            modelBuilder.Entity<Corriente>()
               .HasMany(cor => cor.IvasPagados)
               .WithOne(ivp => ivp.Corriente)
               .HasForeignKey(ivp => ivp.CorrienteID);
            //corriente con inventario
            modelBuilder.Entity<Corriente>()
                .HasOne(cor => cor.Inventario)
                .WithOne(inv=>inv.Corriente)
                .HasForeignKey<Inventario>(inv=>inv.CorrienteID);
            //correinte con documentos por cobrar
            modelBuilder.Entity<Corriente>()
               .HasMany(cor => cor.DocumentosCobrars)
               .WithOne(dxc => dxc.Corriente)
               .HasForeignKey(dxc => dxc.CorrienteID);
            //corriente con suministros
            modelBuilder.Entity<Corriente>()
               .HasMany(cor => cor.Suminitros)
               .WithOne(sum=>sum.Corriente)
               .HasForeignKey(sum => sum.CorrienteID);

            //fijo con terrenos
            modelBuilder.Entity<Fijo>()
               .HasMany(fij=>fij.Terrenos)
               .WithOne(ter=>ter.Fijo)
               .HasForeignKey(ter=>ter.FijoID);
            //fijos con edificio
            modelBuilder.Entity<Fijo>()
               .HasMany(fij => fij.Edificios)
               .WithOne(edi=>edi.Fijo)
               .HasForeignKey(edi=>edi.FijoID);
            //edifico con depreciacion edificio 
            modelBuilder.Entity<Edificio>()
               .HasOne(edi => edi.DepreciacionEdificio)
               .WithOne(dep => dep.Edificio)
               .HasForeignKey<DepreciacionEdificio>(dep => dep.EdificioID);
            //fijo con equipos de oficina 
            modelBuilder.Entity<Fijo>()
               .HasMany(fij => fij.EquiposOficinas)
               .WithOne(edo=>edo.Fijo)
               .HasForeignKey(edo=>edo.FijoID);
            //equipos de oficina con depreciacion de equipos
            modelBuilder.Entity<EquiposOficina>()
               .HasOne(edo => edo.DepreciacionEquipos)
               .WithOne(dep => dep.EquiposOficina)
               .HasForeignKey<DepreciacionEquipos>(dep => dep.EquiposOficinaID);
            //fijos con vehiculos
            modelBuilder.Entity<Fijo>()
               .HasMany(fij => fij.Vehiculos)
               .WithOne(veh=>veh.Fijo)
               .HasForeignKey(veh=>veh.FijoID);

            //Plazo largo con prestamos bancarios
            modelBuilder.Entity<PlazoLargo>()
               .HasMany(pl=>pl.PrestamosBancarios)
               .WithOne(pb=>pb.PlazoLargo)
               .HasForeignKey(pb=>pb.PlazoLargoID);

            //plazo corto con iva cobarado
            modelBuilder.Entity<PlazoCorto>()
               .HasMany(pc => pc.IvaCobrados)
               .WithOne(ivc => ivc.PlazoCorto)
               .HasForeignKey(ivc=>ivc.PlazoCortoID);
            //plazo corto con impuestos por pagar
            modelBuilder.Entity<PlazoCorto>()
               .HasMany(pc => pc.ImpuestosPagars)
               .WithOne(ixp => ixp.PlazoCorto)
               .HasForeignKey(ixp => ixp.PlazoCortoID);
            //plazo corto con intereses por pagar 
            modelBuilder.Entity<PlazoCorto>()
               .HasMany(pc => pc.InteresesPagars)
               .WithOne(inxp => inxp.PlazoCorto)
               .HasForeignKey(inxp => inxp.PlazoCortoID);
            //plazo corto con proveedores
            modelBuilder.Entity<PlazoCorto>()
               .HasMany(pc => pc.Proveedores)
               .WithOne(pro => pro.PlazoCorto)
               .HasForeignKey(pro => pro.PlazoCortoID);
            //plazo corto con documentos por pagar
            modelBuilder.Entity<PlazoCorto>()
               .HasMany(pc => pc.DocuementosPagars)
               .WithOne(dxp => dxp.PlazoCorto)
               .HasForeignKey(dxp => dxp.PlazoCortoID);
            //plazo corto con iees ppor pagar
            modelBuilder.Entity<PlazoCorto>()
               .HasMany(pc => pc.IeesPagars)
               .WithOne(iees => iees.PlazoCorto)
               .HasForeignKey(iees => iees.PlazoCortoID);

            //patrimonio con capital
            modelBuilder.Entity<Patrimonio>()
               .HasOne(patr=>patr.Capital)
               .WithOne(cap=>cap.Patrimonio)
               .HasForeignKey<Capital>(cap=>cap.PatrimonioID);
            //patrimonio con utilidad de ejercicio
            modelBuilder.Entity<Patrimonio>()
               .HasOne(patr => patr.UtilidadEjercicio)
               .WithOne(ute => ute.Patrimonio)
               .HasForeignKey<UtilidadEjercicio>(ute => ute.PatrimonioID);
        }        
    }
}
