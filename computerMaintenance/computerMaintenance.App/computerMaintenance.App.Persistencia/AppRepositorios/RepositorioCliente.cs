using System.Collections.Generic;
// LINQ (Language Integrated Query) es un conjunto de extensiones integradas en el lenguaje C#, que nos permite trabajar de manera cómoda y rápida con colecciones de datos, como si de una base de datos se tratase. Es decir, podemos llevar a cabo inserciones, selecciones y borrados, así como operaciones sobre sus elementos.
using System.Linq; 
using computerMaintenance.App.Dominio;
 
namespace computerMaintenance.App.Persistencia
{
 
    public class RepositorioCliente : IRepositorioCliente
    {
        /// <summary>
        /// Referencia al contexto de Cliente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }
 
        Cliente IRepositorioCliente.AddCliente(Cliente cliente)
        {
            var clienteAdicionado = _appContext.tablaCliente.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
 
        }
 
        // void IRepositorioCliente.DeletePaciente(int idPaciente)
        // {
        //     var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        //     if (pacienteEncontrado == null)
        //         return;
        //     _appContext.Pacientes.Remove(pacienteEncontrado);
        //     _appContext.SaveChanges();
        // }
 
        IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
        {
            return _appContext.tablaCliente;
        }
 
        // Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        // {
        //     return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        // }
 
        // Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        // {
        //     var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
        //     if (pacienteEncontrado != null)
        //     {
        //         pacienteEncontrado.Nombre = paciente.Nombre;
        //         pacienteEncontrado.Apellidos = paciente.Apellidos;
        //         pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
        //         pacienteEncontrado.Genero = paciente.Genero;
        //         pacienteEncontrado.Direccion = paciente.Direccion;
        //         pacienteEncontrado.Latitud = paciente.Latitud;
        //         pacienteEncontrado.Longitud = paciente.Longitud;
        //         pacienteEncontrado.Ciudad = paciente.Ciudad;
        //         pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
        //         pacienteEncontrado.Familiar = paciente.Familiar;
        //         pacienteEncontrado.Enfermera = paciente.Enfermera;
        //         pacienteEncontrado.Medico = paciente.Medico;
        //         pacienteEncontrado.Historia = paciente.Historia;
 
        //         _appContext.SaveChanges();
 
        //     }
        //     return pacienteEncontrado;
        // }
 
        // Medico IRepositorioPaciente.AsignarMedico(int idPaciente, int idMedico)
        // {
        //     var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        //     if (pacienteEncontrado != null)
        //     {
        //         var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
        //         if (medicoEncontrado != null)
        //         {
        //             pacienteEncontrado.Medico = medicoEncontrado;
        //             _appContext.SaveChanges();
        //         }
        //         return medicoEncontrado;
        //     }
        //     return null;
 
        // }
    }
}