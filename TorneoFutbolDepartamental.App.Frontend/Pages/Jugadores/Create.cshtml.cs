using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDepartamental.App.Dominio;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Frontend.Pages.Jugadores
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        public Jugador jugador {get;set;}
        public CreateModel(IRepositorioJugador repoJugador)
        {
            _repoJugador = repoJugador;
        }
        public void OnGet()
        {
            jugador = new Jugador();
        }

        public IActionResult OnPost(Jugador jugador)
        {
            if(ModelState.IsValid)
            {
                _repoJugador.AddJugador(jugador);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
