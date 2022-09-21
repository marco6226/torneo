using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AppContext:DbContext
    {
        //Atributos
        public DbSet<Municipio> Municipios {get;set;}
        public DbSet<Patrocinador> Patrocinadores {get;set;}
        public DbSet<Colegio> Colegios {get;set;}
        public DbSet<Torneo> Torneos {get;set;}
        public DbSet<UnidadDeportiva> UnidadDeportivas {get;set;}
        public DbSet<Equipo> Equipos {get;set;}
        public DbSet<Entrenador> Entrenadores {get;set;}
        public DbSet<TorneoEquipo> TorneoEquipos {get;set;}
        public DbSet<Arbitro> Arbitros {get;set;}

        //<crear la conexion con la base de datos

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Eventos30");
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Define una llave primaria compuesta
            modelBuilder.Entity<TorneoEquipo>().HasKey(x=>new {x.TorneoId,x.EquipoId});

            //Marcar un campo como unico
            modelBuilder.Entity<Torneo>().HasIndex(t => t.Nombre).IsUnique();
            modelBuilder.Entity<Municipio>().HasIndex(m => m.Nombre).IsUnique();
            modelBuilder.Entity<Equipo>().HasIndex(e => e.Nombre).IsUnique();
        }

    }
}