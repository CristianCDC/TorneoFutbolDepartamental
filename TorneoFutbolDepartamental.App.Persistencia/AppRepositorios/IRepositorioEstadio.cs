using System.Collections.Generic;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public interface IRepositorioEstadio {
        Estadio AddEstadio (Estadio estadio);
        IEnumerable<Estadio> GetAllEstadios(); 
        void DeleteEstadio(int idEstadio);
        public Estadio GetEstadio(int idEstadio);
        //public Estadio UpdateEstadio(Estadio estadio);

    }
}