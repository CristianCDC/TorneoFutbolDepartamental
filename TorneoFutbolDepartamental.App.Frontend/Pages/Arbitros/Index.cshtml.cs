using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.pages.Arbitros
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        public IEnumerable<Arbitro> arbitros {get;set;}
        public string bActual {get;set;}
        public IndexModel(IRepositorioArbitro repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }
        public void OnGet(string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                arbitros = _repoArbitro.GetAllArbitros();
            }
            else
            {
                bActual = b;
                arbitros = _repoArbitro.SearchArbitros(b);
            }
        }
    }
}
