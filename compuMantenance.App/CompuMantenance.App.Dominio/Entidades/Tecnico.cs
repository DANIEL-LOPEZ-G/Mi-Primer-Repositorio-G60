using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompuMantenance.App.Dominio.Entidades
{
    public class Tecnico: Persona 
    {

        public string NivelAcademico { get; set; }
        public string CodigoRegistro { get; set; }
    }
}