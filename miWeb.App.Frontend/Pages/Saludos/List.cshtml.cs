using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using miWeb.App.Dominio;
using miWeb.App.Persistencia;
namespace miWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        //private string[] saludos = {"Buenos dias","Buenas Tardes","Buenas noches"};
        //public List<string> listaSaludos{get;set;}
        public readonly IRepositorioSaludos repositoriosaludos;
        public IEnumerable<Saludo> Saludos{get;set;}
        public Saludo Saludo{get;set;}
        public string Filtro{get;set;}
        public DateTime FiltroHora{get;set;}
        public ListModel(IRepositorioSaludos repositoriosaludos)
        {
            this.repositoriosaludos=repositoriosaludos;
        }

        /*public void OnGet()
        {
            listaSaludos = new List<string>();
            listaSaludos.AddRange(saludos);
        }*/
        
        public void OnGet()
        {
            Saludos=repositoriosaludos.GetAll();
        }
        /*
        public void OnGet(string filtro)
        {
            Filtro = filtro;
            Saludos=repositoriosaludos.GetSaludosPorFiltro(filtro);
        }*/
        /*public void OnGet(DateTime filtroHora)
        {
            FiltroHora = filtroHora;
            Saludo=repositoriosaludos.GetSaludoHora(filtroHora);
        }*/
    }
}
