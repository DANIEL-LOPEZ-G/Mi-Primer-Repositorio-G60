using System;
namespace computerMaintenance.App.Dominio
{
    /// <summary>Class <c>HistoriaCliente</c>
    /// Modela la historia de cliente
    /// </summary>
    public class HistoriaCliente 
    {
        ///Relación entre HistoriaCliente y Cliente
        public Cliente Cliente { get; set; }       
        /// relación entre HistoriaCliente y NuevaSolicitud
        public NuevaSolicitud NuevaSolicitud { get; set; }
    }
}