using System;
namespace computerMaintenance.App.Dominio
{
    /// <summary>Class <c>Cliente</c>
    /// Modela un Cliente
    /// </summary>
    public class Cliente : Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        ///Ciudad de ubicación del paciente
        public string Ciudad { get; set; }       
        /// Relacion entre Cliente y el Tecnico que lo atiende
        public Tecnico Tecnico { get; set; }
        /// Relacion entre Cliente y su Historial solicitudes
        public Historia Historia { get; set; }
        /// <summary>
        /// Referencia a la lista de opciones para cliente
        /// </summary>
        /// <value></value>
        public System.Collections.Generic.List<TipoRequerimiento> TipoRequerimiento { get; set; }
    }
}