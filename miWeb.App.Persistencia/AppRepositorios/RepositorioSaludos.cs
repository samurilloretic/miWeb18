using System;
using miWeb.App.Dominio;
using System.Collections.Generic;

namespace miWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioSaludos: IRepositorioSaludos
    {
        List<Saludo> saludos;

        public RepositorioSaludos()
        {
            saludos=new List<Saludo>()
            {
                new Saludo{Id=1,EnEspañol="Buenos Dias",EnIngles="Good Morning",EnItaliano="Bongiorno"},
                new Saludo{Id=2,EnEspañol="Buenos Tardes",EnIngles="Good Evening",EnItaliano="Buon Pomeriggio"},
                new Saludo{Id=3,EnEspañol="Buenos Noches",EnIngles="Good Afternoon",EnItaliano="Buona notte"}
            };
        }

        public IEnumerable<Saludo> GetAll()
        {
            return saludos;
        }
    }
}