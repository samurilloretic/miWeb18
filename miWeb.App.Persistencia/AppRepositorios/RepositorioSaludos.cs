using System;
using miWeb.App.Dominio;
using System.Collections.Generic;
using System.Linq;



namespace miWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioSaludos: IRepositorioSaludos
    {
        List<Saludo> saludos;
        Saludo saludo;
        public RepositorioSaludos()
        {
            saludos=new List<Saludo>()
            {
                new Saludo{Id=1,EnEspañol="Buenos Dias",EnIngles="Good Morning",EnItaliano="Bongiorno"},
                new Saludo{Id=2,EnEspañol="Buenas Tardes",EnIngles="Good Evening",EnItaliano="Buon Pomeriggio"},
                new Saludo{Id=3,EnEspañol="Buenas Noches",EnIngles="Good Afternoon",EnItaliano="Buona notte"},
                new Saludo{Id=4,EnEspañol="Hora inválida",EnIngles="invalid hour",EnItaliano="Tempo no valido"}
            };
        }

        public IEnumerable<Saludo> GetAll()
        {
            return saludos;
        }

        public IEnumerable<Saludo> GetSaludosPorFiltro(string filtro=null)
        {
            var saludos = GetAll();
            if (saludos!=null)
            {
                if(!String.IsNullOrEmpty(filtro))
                {
                    saludos = saludos.Where(s=>s.EnEspañol.Contains(filtro) | s.EnIngles.Contains(filtro) | s.EnItaliano.Contains(filtro));
                }
            }
            return saludos;
        }


        public Saludo GetSaludoHora(DateTime filtro)
        {            
            if (filtro < Convert.ToDateTime("12:00:00"))
            {
                saludo = saludos.ElementAt(0);
            }else if (filtro < Convert.ToDateTime("18:00:00"))
            {
                saludo = saludos.ElementAt(1);
            }else if(filtro < Convert.ToDateTime("23:59:00"))
            {
                saludo = saludos.ElementAt(2);
            }else if (filtro > Convert.ToDateTime("23:59:00"))
            {
                saludo = saludos.ElementAt(3);
            }
            return saludo;
        }

        public Saludo GetSaludoId(int id)
        {
            return saludos.SingleOrDefault(s=>s.Id==id);
        }

        public Saludo Update(Saludo saludoActualizado)
        {
            //Console.WriteLine(saludoActualizado.Id);
            var saludo = saludos.SingleOrDefault(r=>r.Id==saludoActualizado.Id);
            if(saludo!=null)
            {
                saludo.EnEspañol = saludoActualizado.EnEspañol;
                saludo.EnIngles = saludoActualizado.EnIngles;
                saludo.EnItaliano = saludoActualizado.EnItaliano;
            }
            return saludo;
        }
    }
}