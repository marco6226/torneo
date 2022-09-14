using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IREquipo
    {
        public bool CrearEquipo(Equipo equipo);
        public Equipo BuscarEquipo(int id);
        public bool ActualizarEquipo(Equipo equipo);
        public bool EliminarEquipo(int id);
        public IEnumerable<Equipo> ListarEquipos();
        public List<Equipo> ListarEquipos1();
    }
}