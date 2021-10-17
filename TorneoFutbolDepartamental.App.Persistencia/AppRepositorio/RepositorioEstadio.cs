using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolDepartamental.App.Dominio;

namespace TorneoFutbolDepartamental.App.Persistencia
{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioEstadio()
        {
        }

        public RepositorioEstadio (AppContext appContext)
        {
            _appContext=appContext;
        }

        Estadio IRepositorioEstadio.AddEstadio (Estadio estadio)
        {
            var EstadioAñadido = _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return EstadioAñadido.Entity;
        }
        
        void IRepositorioEstadio.DeleteEstadio (int Estadioid)
        {
            var EstadioEncontrado = _appContext.Estadios.FirstOrDefault(es => es.EstadioId == Estadioid);
            if (EstadioEncontrado == null)
                return;
            _appContext.Estadios.Remove(EstadioEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Estadio> IRepositorioEstadio.GetAllEstadios ()
        {
            return _appContext.Estadios;
        }

        Estadio IRepositorioEstadio.GetEstadio (int Estadioid)
        {
            var estadio = _appContext.Estadios.Where(es => es.EstadioId == Estadioid).Include(es => es.Municipio).FirstOrDefault();
            return estadio;
        }

        Estadio IRepositorioEstadio.UpdateEstadio (Estadio estadio)
        {
            var EstadioEncontrado = _appContext.Estadios.FirstOrDefault(es=> es.EstadioId == estadio.EstadioId);
            if (EstadioEncontrado != null)
            {
                EstadioEncontrado.Nombre = estadio.Nombre;
                EstadioEncontrado.Direccion = estadio.Direccion;
                EstadioEncontrado.Ciudad = estadio.Ciudad;
                EstadioEncontrado.Municipio = estadio.Municipio;

                _appContext.SaveChanges();
            }
            return EstadioEncontrado;
        }

        Municipio IRepositorioEstadio.AsignarMunicipio(int Estadioid, int Municipioid)
        {
            var estadioEncontrado = _appContext.Estadios.Find(Estadioid);
            if(estadioEncontrado != null)
            {
                var municipioEncontrado = _appContext.Municipios.Find(Municipioid);
                if(municipioEncontrado != null)
                {
                    estadioEncontrado.Municipio = municipioEncontrado;
                    _appContext.SaveChanges();
                }
                return municipioEncontrado;
            }
            return null;
        }

        IEnumerable<Estadio> IRepositorioEstadio.SearchEstadios(string nombre)
        {
            return _appContext.Estadios.Where(es => es.Nombre.Contains(nombre));
        }
    }
}