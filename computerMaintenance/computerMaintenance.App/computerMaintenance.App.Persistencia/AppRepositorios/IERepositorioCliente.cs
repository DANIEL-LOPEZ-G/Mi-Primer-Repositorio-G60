using System;
using System.Collections.Generic;
using System.Linq;
using computerMaintenance.App.Dominio;
namespace computerMaintenance.App.Persistencia
{
    public interface IRepositorioCliente
    {
        IEnumerable<Cliente> GetAllClientes();
        Cliente AddCliente(Cliente cliente);
        // Paciente UpdatePaciente(Paciente paciente);
        // void DeletePaciente(int idPaciente);
        // Paciente GetPaciente(int idPaciente);
        // Medico AsignarMedico(int idPaciente, int idMedico);
    }
}