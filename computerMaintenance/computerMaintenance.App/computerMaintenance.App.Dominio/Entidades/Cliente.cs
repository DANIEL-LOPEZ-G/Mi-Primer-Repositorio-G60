using System;
namespace computerMaintenance.App.Dominio
{
    /// <summary>Class <c>Cliente</c>
    /// Modela un Cliente
    /// </summary>
    public class Cliente : Persona
    {

        ///Ciudad de ubicación del paciente
        public string Ciudad { get; set; }       
        /// Relacion entre Cliente y el Tecnico que lo atiende
        public Tecnico Tecnico { get; set; }
        /// Relacion entre Cliente y su Historial solicitudes
        //public HistoriaCliente HistoriaCliente { get; set; }
        // <summary>
        /// Referencia a la lista de opciones para cliente
        /// </summary>
        // <value></value>
        //public System.Collections.Generic.List<TipoRequerimiento> TipoRequerimiento { get; set; }
    }
}