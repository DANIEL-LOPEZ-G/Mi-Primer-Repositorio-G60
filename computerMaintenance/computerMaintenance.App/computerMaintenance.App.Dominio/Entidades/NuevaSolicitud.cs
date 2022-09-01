using System;
namespace computerMaintenance.App.Dominio
{
    /// <summary>Class <c>NuevaSolicitud</c>
    /// Modela una nueva solicitud de cliente
    /// </summary>
    public class NuevaSolicitud 
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        ///Relación entre NuevaSolicitud y Cliente
        public Cliente Cliente { get; set; }       
        /// relación entre GestionarServicio y NuevaSolicitud
        public Tecnico Tecnico { get; set; }
    }
}