using Microsoft.EntityFrameworkCore;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Arbitro> Arbitros {get;set;}
        public DbSet<Equipo> Equipos {get;set;}
        public DbSet<Estadio> Estadios  {get;set;}
        public DbSet<Jugador> Jugadores {get;set;}
        public DbSet<Municipio> Municipios {get;set;}
        public DbSet<Partido> Partidos {get;set;}
        public DbSet<DirectorTecnico> Tecnicos  {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured){
                optionBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = TorneoFutbolDepartamentalData");
            }
        }
    }
}