namespace DATOS
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;


    public class MODELO_SEGURIDAD : DbContext
    {
        private static MODELO_SEGURIDAD INSTANCIA;
        public static MODELO_SEGURIDAD Singleton()
        {
            if (INSTANCIA == null) INSTANCIA = new MODELO_SEGURIDAD();
            return INSTANCIA;
        }
        // El contexto se ha configurado para usar una cadena de conexión 'MODELO_SEGURIDAD' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'DATOS.MODELO_SEGURIDAD' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'MODELO_SEGURIDAD'  en el archivo de configuración de la aplicación.
        public MODELO_SEGURIDAD()
            : base("name=MODELO SEGURIDAD")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<MODELO.GRUPO>()
                .HasKey(_ => _.Codigo)
                .HasMany(e => e.Usuarios)
                .WithMany(e => e.Grupos)
                .Map(m => m.ToTable("USUARIOGRUPO").MapLeftKey("GRUPO_CODIGO"));

            modelBuilder.Entity<MODELO.GRUPO>()
                           .HasMany(g => g.Permisos)
                           .WithMany(g => g.Grupos)
                           .Map(m => m.ToTable("PERMISOGRUPO").MapLeftKey("GRUPO_CODIGO"));

           



            modelBuilder.Entity<MODELO.USUARIO>()
                .HasKey(_ => _.Codigo);

            modelBuilder.Entity<MODELO.SEGURIDAD.ACCESO>()
                .HasKey(_ => _.IDAcceso);

            modelBuilder.Entity<MODELO.PERMISO>()
                .HasKey(_ => _.Codigo);

            modelBuilder.Entity<MODELO.SEGURIDAD.AUDITORIA>()
               .HasKey(_ => _.IDAuditoria);

            modelBuilder.Entity<MODELO.Proveedor>()
                .HasKey(_ => _.codigo);

            modelBuilder.Entity<MODELO.Localidad>()
               .HasKey(_ => _.codigo);

            modelBuilder.Entity<MODELO.Cliente>()
               .HasKey(_ => _.codigo);

            modelBuilder.Entity<MODELO.Clase>()
               .HasKey(_ => _.CODIGO);

            modelBuilder.Entity<MODELO.Subclase>()
               .HasKey(_ => _.CODIGO);

            modelBuilder.Entity<MODELO.Materiales>()
               .HasKey(_ => _.CODIGO)
               .HasMany(e=>e.OrdenesCompras)
               .WithMany(e=>e.Materiales);

            modelBuilder.Entity<MODELO.AuditoriaMateriales>()
               .HasKey(_ => _.IDAuditoria);

            modelBuilder.Entity<MODELO.AuditoriaOC>()
               .HasKey(_ => _.IDAuditoria);

            modelBuilder.Entity<MODELO.AuditoriaRemito>()
               .HasKey(_ => _.IDAuditoria);
              // .HasRequired();

            modelBuilder.Entity<MODELO.AuditoriaVenta>()
               .HasKey(_ => _.IDAuditoria);


            modelBuilder.Entity<MODELO.Factura>()
                .HasKey(_ => _.codigo)
                .HasMany(e => e.CantidadesMat)
                .WithMany(e=>e.OrdenCompra);


            modelBuilder.Entity<MODELO.Venta>()
                .HasKey(_ => _.codigo)
                .HasMany(e => e.CantidadesMat)
                .WithMany(e => e.OrdenVenta);




            modelBuilder.Entity<MODELO.Factura>()
               .HasMany(e => e.Materiales)
               .WithMany(e => e.OrdenesCompras);

            modelBuilder.Entity<MODELO.Remito>()
                .HasKey(_ => _.codigo);

            

            modelBuilder.Entity<MODELO.Occantmat>()
               .HasKey(_ => _.codigo);


               modelBuilder.Entity<MODELO.oCanmatVenta>()
               .HasKey(_ => _.codigo)
               /*.WithMany(e => e.cantidadmat)*/;

            modelBuilder.Entity<MODELO.RemitoUpdated>()
               .HasKey(_ => _.codigo)
               /*.WithMany(e => e.cantidadmat)*/;

            modelBuilder.Entity<MODELO.CantidadMat>()
               .HasKey(_ => _.codigo)
               .HasMany(e=>e.OrdenCompra)
           
               .WithMany(e=>e.CantidadesMat);

            //modelBuilder.Entity<MODELO.OrdenCompra>()
            //   .HasKey(_ => _.IDAuditoria);


        }

        public DbSet<MODELO.USUARIO> USUARIOS { get; set; }
        public DbSet<MODELO.GRUPO> GRUPOS { get; set; }
        public DbSet<MODELO.PERMISO> PERMISOS { get; set; }
        public DbSet<MODELO.SEGURIDAD.ACCESO> ACCESO { get; set; }
        public DbSet<MODELO.SEGURIDAD.AUDITORIA> AUDITORIA { get; set; }
        public DbSet<MODELO.Cliente> CLIENTES { get; set; }
        public DbSet<MODELO.Localidad> LOCALIDADES { get; set; }
        public DbSet<MODELO.Proveedor> PROVEEDORES { get; set; }
        public DbSet<MODELO.Clase> CLASES { get; set; }
        public DbSet<MODELO.Subclase> SUBCLASES { get; set; }
        public DbSet<MODELO.Materiales> MATERIALES { get; set; }
        public DbSet<MODELO.AuditoriaMateriales> AUDITORIAMATERIALES { get; set; }
        public DbSet<MODELO.Factura> ORDENESDECOMPRAS { get; set; }
        public DbSet<MODELO.Venta> ORDENESDEVENTAS { get; set; }
        public DbSet<MODELO.Remito> REMITOS { get; set; }
        public DbSet<MODELO.CantidadMat> CANTIDADESMAT { get; set; }
        public DbSet<MODELO.AuditoriaOC> AuditoriaOC { get; set; }
        public DbSet<MODELO.Occantmat> OccantmatS { get; set; }
        public DbSet<MODELO.oCanmatVenta> OccantmatSVenta { get; set; }
        public DbSet<MODELO.AuditoriaVenta> AUDITORIAVENTAS { get; set; }
        public DbSet<MODELO.AuditoriaRemito> AUDITORIAREMITO { get; set; }

        public DbSet<MODELO.RemitoUpdated> RemitoUpdated { get; set; }


    }


}
