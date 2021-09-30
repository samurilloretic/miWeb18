using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using miWeb.App.Persistencia;
using miWeb.App.Dominio;
namespace miWeb.App.Frontend.Pages
{
    public class EditarModel : PageModel
    {
        private readonly IRepositorioSaludos repositoriosaludos;
        [BindProperty]
        public Saludo Saludo{get; set;}

        public EditarModel(IRepositorioSaludos repositoriosaludos)
        {
            this.repositoriosaludos = repositoriosaludos;
        }

        public IActionResult OnGet(int? saludoId)
        {
            //Adición
            if (saludoId.HasValue)
            {
                Saludo = repositoriosaludos.GetSaludoId(saludoId.Value);
            }else
            {
                Saludo = new Saludo();
            }

            //Update
            //Saludo = repositoriosaludos.GetSaludoId(saludoId);
            if(Saludo==null)
            {
                return RedirectToPage("./List");
            }else
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            //Console.WriteLine(Saludo.Id);
            if(Saludo.Id>0)
            {
                Saludo = repositoriosaludos.Update(Saludo);
            }else
            {
                repositoriosaludos.Add(Saludo);
            }            
            return Page();
        }
    }
}
