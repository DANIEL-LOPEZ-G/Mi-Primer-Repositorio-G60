using System;
namespace computerMaintenance.App.Dominio
{
    /// <summary>Class <c>Administrador</c>
    /// Modela un Administrador
    /// </summary>
    public class Administrador : Persona
    {
        ///Ciudad de ubicación del administrador
        public string Ciudad { get; set; }       
        /// Usuario administrador
        public string usuarioAdministrador { get; set; }  
    }
}