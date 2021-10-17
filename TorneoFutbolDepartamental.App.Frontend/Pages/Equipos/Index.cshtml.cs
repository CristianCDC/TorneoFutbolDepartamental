using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.pages.Equipos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        public IEnumerable<Equipo> equipos {get;set;}
        public string bActual {get;set;}
        public IndexModel(IRepositorioEquipo repoEquipo)
        {
            _repoEquipo = repoEquipo;
        }
        public void OnGet(String b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                equipos = _repoEquipo.GetAllEquipos();
            }
            else
            {
                bActual = b;
                equipos = _repoEquipo.SearchEquipos(b);
            }
        }
    }
}
