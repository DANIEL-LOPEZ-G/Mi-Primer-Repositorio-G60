using System;
namespace computerMaintenance.App.Dominio
{
    /// <summary>Class <c>HistoriaCliente</c>
    /// Modela la historia de cliente
    /// </summary>
    public class HistoriaCliente 
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        ///Relación entre HistoriaCliente y Cliente
        public Cliente Cliente { get; set; }       
        /// relación entre HistoriaCliente y NuevaSolicitud
        public NuevaSolicitud NuevaSolicitud { get; set; }
    }
}