using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompuMantenance.App.Dominio.Entidades;


namespace CompuMantenance.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTecnicos
    {
        IEnumerable<Tecnico> GetAll();
        Tecnico GetTecnicoPorId(int idTecnico);
        Tecnico UpdateTecnico(Tecnico tecnicoActualizado);
        Tecnico AddTecnico(Tecnico nuevoTecnico);

        // Tecnico DeleteTecnico(int tecnicoId);
        
    }
}