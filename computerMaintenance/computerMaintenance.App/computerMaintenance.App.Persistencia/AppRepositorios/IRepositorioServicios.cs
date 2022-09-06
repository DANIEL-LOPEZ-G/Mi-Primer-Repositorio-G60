using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using computerMaintenance.App.Dominio;

namespace computerMaintenance.App.Persistencia.AppRepositorios
{
    public interface IRepositorioServicios
    {
        IEnumerable<Servicios> GetAll();

    }
}