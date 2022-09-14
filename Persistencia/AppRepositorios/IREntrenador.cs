using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IREntrenador
    {
        public bool CrearEntrenador(Entrenador entrenador);
        public Entrenador BuscarEntrenador(int id);
        public bool ActualizarEntrenador(Entrenador entrenador);
        public bool EliminarEntrenador(int id);
        public IEnumerable<Entrenador> ListarEntrenadores();
        public List<Entrenador> ListarEntrenadores1();
    }
}