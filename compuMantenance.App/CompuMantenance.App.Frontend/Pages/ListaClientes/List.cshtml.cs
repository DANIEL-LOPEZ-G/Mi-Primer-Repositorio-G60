using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CompuMantenance.App.Persistencia.AppRepositorios;
using CompuMantenance.App.Dominio.Entidades;

namespace CompuMantenance.App.Frontend.Pages
{
    public class ListModelListaClientes : PageModel
    {
        
        private readonly IRepositorioClientes repositorioClientes;
        public IEnumerable<Cliente> clientes {get; set; }

        public ListModelListaClientes(IRepositorioClientes repositorioClientes)
        {
            this.repositorioClientes = repositorioClientes;
        }

        public void OnGet()
        {
            clientes = repositorioClientes.GetAll();
        }
    }
}
