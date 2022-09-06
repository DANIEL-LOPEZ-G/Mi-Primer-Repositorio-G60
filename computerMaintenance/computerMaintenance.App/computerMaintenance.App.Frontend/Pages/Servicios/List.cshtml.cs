using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace computerMaintenance.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private String[] servicios =
        {
            "Instalación",
            "Configuración",
            "Suministro",
            "Mantenimiento"
        };
        public List<string> ListaServicios { get; set; }

        public void OnGet()
        {
            ListaServicios = new List<string>();
            ListaServicios.AddRange(servicios);
        }
    }
}
