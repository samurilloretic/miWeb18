using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
namespace miWeb.App.Dominio
{
    public class Saludo
    {
        public int Id{get;set;}
        [Required(ErrorMessage = "Falta este dato"),StringLength(50)]
        public string EnEspañol{get;set;}
        [Required]
        public string EnIngles{get;set;}
        [Required]
        public string EnItaliano{get;set;}
    }
}
