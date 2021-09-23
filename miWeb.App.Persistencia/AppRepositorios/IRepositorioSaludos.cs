using System;
using miWeb.App.Dominio;
using System.Collections.Generic;

namespace miWeb.App.Persistencia
{
    public interface IRepositorioSaludos
    {
        IEnumerable<Saludo> GetAll();
    }
}