using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CompuMantenance.App.Persistencia.AppRepositorios;
using CompuMantenance.App.Dominio.Entidades;

namespace CompuMantenance.App.Frontend.Pages.ListaClientes
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioClientes repositorioClientes;
        public Cliente cliente { get; set; }

        public DetailsModel(IRepositorioClientes repositorioClientes)
        {
            this.repositorioClientes = repositorioClientes;
        }

        public IActionResult OnGet(int clienteId)
        {
            cliente = repositorioClientes.GetClientePorId(clienteId);
            if(cliente == null)
            {
                return RedirectToPage(".NotFound");
            }
            else
                return Page();
        }
    }
}