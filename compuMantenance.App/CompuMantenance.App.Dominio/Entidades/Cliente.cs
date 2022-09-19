using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CompuMantenance.App.Dominio.Entidades
{
    public class Cliente: Persona
    {

        //public int IdCliente { get; set; }

        [Required, StringLength(50)]
        public string Direccion { get; set; }
    }
}