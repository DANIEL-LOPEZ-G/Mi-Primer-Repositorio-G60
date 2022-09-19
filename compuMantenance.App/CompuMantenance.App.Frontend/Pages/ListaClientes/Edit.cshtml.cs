using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CompuMantenance.App.Persistencia.AppRepositorios;
using CompuMantenance.App.Dominio.Entidades;
using System.Collections.Generic;

namespace CompuMantenance.App.Frontend.Pages.ListaClientes
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioClientes repositorioClientes;

        [BindProperty]
        public Cliente cliente { get; set; }

        public EditModel(IRepositorioClientes repositorioClientes)
        {
            this.repositorioClientes = repositorioClientes;
        }

        public IActionResult OnGet(int? clienteId) //para que el HasValue pueda funcionar
        {
            if (clienteId.HasValue)
            {
                cliente = repositorioClientes.GetClientePorId(clienteId.Value);
            }
            else
            {
                cliente = new Cliente();
            }

            if (cliente == null)
            {
                return RedirectToPage(".NotFound");
            }
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(cliente.Id > 0 )
            {
                cliente = repositorioClientes.UpdateCliente(cliente);
            }
            else
            {   
                repositorioClientes.AddCliente(cliente);
            }
            
            return Page();
        }
    }
}
