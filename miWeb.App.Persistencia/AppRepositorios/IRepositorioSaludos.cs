using System;
using miWeb.App.Dominio;
using System.Collections.Generic;

namespace miWeb.App.Persistencia
{
    public interface IRepositorioSaludos
    {
        IEnumerable<Saludo> GetAll();

        IEnumerable<Saludo> GetSaludosPorFiltro(string filtro);

        Saludo GetSaludoHora(DateTime filtro);

        Saludo GetSaludoId(int id);

        Saludo Update(Saludo saludoActualizado);

        Saludo Add(Saludo saludoNuevo);
    }
}