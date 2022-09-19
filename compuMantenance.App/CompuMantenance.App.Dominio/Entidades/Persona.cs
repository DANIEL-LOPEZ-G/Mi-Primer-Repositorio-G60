using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CompuMantenance.App.Dominio.Entidades
{
    public class Persona
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nombre { get; set; }

        [Required, StringLength(50)]
        public string Apellidos { get; set; }
        
        [Required, StringLength(50)]
        public string NumeroTelefono { get; set; }

        [Required]
        public Genero Genero { get; set; }
    }
}