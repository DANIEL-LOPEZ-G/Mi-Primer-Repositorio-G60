using Microsoft.EntityFrameworkCore;
using computerMaintenance.App.Dominio; //Traigo las entidades de dominio

namespace computerMaintenance.App.Persistencia
{
    public class AppContext: DbContext
    {
        public DbSet<Administrador> tablaAdministrador {get;set;}
        public DbSet<Cliente> tablaCliente{get;set;}
        public DbSet<GestionarServicio> tablaGestionarServicio {get;set;}
        public DbSet<HistoriaCliente> tablaHistoriaCliente {get;set;}
        public DbSet<HistoriaTecnico> HistoriaTecnico {get;set;}
        public DbSet<NuevaSolicitud> tablaNuevaSolicitud {get;set;}
        public DbSet<Persona> tablaPersona {get;set;}
        public DbSet<Tecnico> tablaTecnico {get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = cumputerMaintenance1.0");
        }
    }    
    }

}