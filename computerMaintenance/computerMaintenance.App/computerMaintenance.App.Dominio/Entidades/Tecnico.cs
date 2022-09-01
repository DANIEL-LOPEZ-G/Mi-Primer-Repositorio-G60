namespace computerMaintenance.App.Dominio
{
    /// <summary>Class <c>Tecnico</c>
    /// Modela un Tecnico del equipo tecnicos de apoyo
    /// </summary>
    public class Tecnico : Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        /// Código único de tecnico
        public string nroTarjetaProfesional { get; set; }

    }
}