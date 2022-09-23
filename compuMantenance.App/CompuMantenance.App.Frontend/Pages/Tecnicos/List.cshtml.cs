using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using CompuMantenance.App.Persistencia.AppRepositorios;
using CompuMantenance.App.Dominio.Entidades;


namespace CompuMantenance.App.Frontend.Pages
{
    public class ListModelTecnicos : PageModel
    {
        
        private readonly IRepositorioTecnicos repositorioTecnicos;
        public IEnumerable<Tecnico> tecnicos {get; set; }

        public ListModelTecnicos(IRepositorioTecnicos repositorioTecnicos)
        {
            this.repositorioTecnicos = repositorioTecnicos;
        }

        public void OnGet()
        {
            tecnicos = repositorioTecnicos.GetAll();
        }
    }
}