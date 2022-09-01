using System;
namespace computerMaintenance.App.Dominio
{
    /// <summary>Class <c>GestionarServicio</c>
    /// Modela la gestión del servicio solicitado de cliente
    /// </summary>
    public class GestionarServicio 
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        ///Relación entre GestionarServicio y Administador
        public Administador Administador { get; set; }       
        /// relación entre GestionarServicio y NuevaSolicitud
        public NuevaSolicitud NuevaSolicitud { get; set; }
    }
}