using System.Reflection.Metadata;
using System.CodeDom.Compiler;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompuMantenance.App.Dominio.Entidades;

namespace CompuMantenance.App.Persistencia.AppRepositorios
{
    public class RepositorioTecnicosMemoria: IRepositorioTecnicos
    {
        List<Tecnico> tecnicos;
        public RepositorioTecnicosMemoria()
        {
            tecnicos = new List<Tecnico>()
            {
                new Tecnico{Id = 1, Nombre = "Jhomaro Alberto", Apellidos = "Gaviria Cataño", NumeroTelefono = "3175208767", Genero = Genero.Masculino, NivelAcademico = "Cra 36 Nro 18B 46", CodigoRegistro = "abg67"},
                new Tecnico{Id = 2, Nombre = "Maria Fernanda", Apellidos = "Gaviria Franco", NumeroTelefono = "3214569878", Genero = Genero.Femenino, NivelAcademico = "Cra 36 Nro 18B 46", CodigoRegistro = "asr47"},
                new Tecnico{Id = 3, Nombre = "Viviana Marcela", Apellidos = "Franco Gonzalez", NumeroTelefono = "3127210570", Genero = Genero.Femenino, NivelAcademico = "Cra 36 Nro 18B 46", CodigoRegistro = "wer43"},
            };
        }   
        public IEnumerable<Tecnico> GetAll()
        {
            return tecnicos;
        }

        public Tecnico AddTecnico(Tecnico nuevoTecnico)
        {
            nuevoTecnico.Id = tecnicos.Max(r => r.Id) + 1;   
            tecnicos.Add(nuevoTecnico); 
            return nuevoTecnico;
        }
        public Tecnico GetTecnicoPorId(int idTecnico)
        {
            return tecnicos.FirstOrDefault(t => t.Id == idTecnico);
        }

        public Tecnico UpdateTecnico(Tecnico tecnicoActualizado)
        {
            var tecnico = tecnicos.SingleOrDefault(t => t.Id == tecnicoActualizado.Id);
            if(tecnico != null)
            {
                tecnico.Nombre = tecnicoActualizado.Nombre;
                tecnico.Apellidos = tecnicoActualizado.Apellidos;
                tecnico.NumeroTelefono = tecnicoActualizado.NumeroTelefono;
                tecnico.Genero = tecnicoActualizado.Genero;
                tecnico.NivelAcademico = tecnicoActualizado.NivelAcademico;
                tecnico.CodigoRegistro = tecnicoActualizado.CodigoRegistro;             
            }
            return tecnico;
        }
            
    }
}