using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.pages.DirectoresTecnicos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public IEnumerable<DirectorTecnico> directoresTecnicos {get;set;}
        public string bActual {get;set;}
        public IndexModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public void OnGet(string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                directoresTecnicos = _repoDirectorTecnico.GetAllDirectoresTecnicos();
            }
            else
            {
                bActual = b;
                directoresTecnicos = _repoDirectorTecnico.SearchDirectoresTecnicos(b);
            }
        }
    }
}
