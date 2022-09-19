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
    public class RepositorioClientesMemoria: IRepositorioClientes
    {
        List<Cliente> clientes;
        public RepositorioClientesMemoria()
        {
            clientes = new List<Cliente>()
            {
                new Cliente{Id = 1, Nombre = "Jhomaro Alberto", Apellidos = "Gaviria Cataño", NumeroTelefono = "3175208767", Genero = Genero.Masculino, Direccion = "Cra 36 Nro 18B 46"},
                new Cliente{Id = 2, Nombre = "Maria Fernanda", Apellidos = "Gaviria Franco", NumeroTelefono = "3214569878", Genero = Genero.Femenino, Direccion = "Cra 36 Nro 18B 46"},
                new Cliente{Id = 3, Nombre = "Viviana Marcela", Apellidos = "Franco Gonzalez", NumeroTelefono = "3127210570", Genero = Genero.Femenino, Direccion = "Cra 36 Nro 18B 46"},
            };
        }   
        public IEnumerable<Cliente> GetAll()
        {
            return clientes;
        }

        public Cliente AddCliente(Cliente nuevoCliente)
        {
            nuevoCliente.Id = clientes.Max(r => r.Id) + 1;   
            clientes.Add(nuevoCliente); 
            return nuevoCliente;
        }
        public Cliente GetClientePorId(int clienteId)
        {
            return clientes.FirstOrDefault(c => c.Id == clienteId);
        }

        public Cliente UpdateCliente(Cliente clienteActualizado)
        {
            var cliente = clientes.SingleOrDefault(r => r.Id == clienteActualizado.Id);
            if(cliente != null)
            {
                cliente.Nombre = clienteActualizado.Nombre;
                cliente.Apellidos = clienteActualizado.Apellidos;
                cliente.NumeroTelefono = clienteActualizado.NumeroTelefono;
                cliente.Genero = clienteActualizado.Genero;
                cliente.Direccion = clienteActualizado.Direccion;                
            }
            return cliente;
        }
            
    }
}