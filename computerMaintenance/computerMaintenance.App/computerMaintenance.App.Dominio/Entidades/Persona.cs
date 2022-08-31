namespace computerMaintenance.App.Dominio
{
    /// <summary>Class <c>Persona</c>
    /// Modela una Persona en general en el sistema
    /// </summary>
    public class Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public int nroIdentificacion { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string fechaNacimiento { get; set; }
        public string tipoUsuario { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        // Genero de la persona
        public Genero Genero { set; get; }
    }
}