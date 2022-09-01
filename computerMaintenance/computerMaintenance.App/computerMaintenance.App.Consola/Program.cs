using System;
using computerMaintenance.App.Dominio;
using computerMaintenance.App.Persistencia;
namespace computerMaintenance.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente= new RepositorioCliente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Computer Maintenance Project");
            AddCliente();
            //BuscarPaciente(1);
            //AsignarMedico();
        }
        private static void AddCliente()
        {
            var cliente = new Cliente
        {
            nroIdentificacion = 71194536,
            nombres = "Jhomaro Alberto ",
            apellidos = "Gaviria Cataño",
            direccion = "Bellavista",
            fechaNacimiento = "1984-08-23",
            tipoUsuario = "Cliente",
            user = "JhomaGC",
            password = "123456",
            Genero = Genero.Masculino
            
        };
        _repoCliente.AddCliente(cliente);
        Console.WriteLine("usuario Agregado con exito");
        }
        // private static void BuscarPaciente(int idPaciente)
        // {
        //     var paciente = _repoPaciente.GetPaciente(idPaciente);
        //     Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
        // }
        // private static void AsignarMedico()
        // {
        //     var medico = _repoPaciente.AsignarMedico(1,2);
        //     Console.WriteLine(medico.Nombre+" "+medico.Apellidos);
        // }
    }
}