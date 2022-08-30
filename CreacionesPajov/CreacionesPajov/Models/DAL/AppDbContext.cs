using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CreacionesPajov.WEB.Models.DAL
{
    public class AppDbContext:IdentityDbContext

    {
        //Opciones de cadena de conexion
        public AppDbContext(DbContextOptions<AppDbContext> options)  :base (options)
        {

        }

        //Esto lo utilizamos para llenar las tablas (seeder)
        //Notas:El ModelBuilder es el encargado de crear el modelo, es el que crea la base de datos
        //(es el constructor del modelo).
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();


        }


       
        //DbSet o represe3ntacion de nuestras tablas
        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<TipoDocumento> TiposDocumento { get; set; }

       

        public DbSet<TipoOperacion> TiposOperacion { get; set; }

        public DbSet<TipoJornada> TiposJornadas { get; set; }

        public DbSet<Operacion> Operaciones { get; set; }
        
        public DbSet<Fase> Fases { get; set; }

        public DbSet<SubFase> SubFases { get; set; }

        public DbSet<Remision> Remisiones { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<ColorHilo> ColorHilos { get; set; }

      

        public DbSet<ColorTela> ColorTelas { get; set; }

        public DbSet<ProveedorTela> ProveedorTelas { get; set; }

        public DbSet<TipoPrenda> TipoPrendas { get; set; }

        public DbSet<ProveedorHilo> ProveedorHilos { get; set; }

    
        public DbSet<TipoNovedadEmpleado> TipoNovedadEmpleados { get; set; }

        public DbSet<TipoReporteProduccion> TipoReportesProduccion { get; set; }

        public DbSet<ReporteProduccion> ReportesProduccion { get; set; }

        public DbSet<Hilo> Hilos { get; set; }

        public DbSet<ControlLote> ControlLotes { get; set; }
        public DbSet<DetalleHilo> DetalleHilos { get; set; }

        public DbSet<Tela> Telas { get; set; }

        public DbSet<DetalleTela> DetalleTelas { get; set; }

        public DbSet<Produccion> Producciones { get; set; }

        public DbSet<ProduccionGrupal> ProduccionesGrupales { get; set; }

        //public DbSet<DetalleLote> DetalleLotes { get; set; }  


        //public DbSet<Administrador> Administradores { get; set; }



    }
}
