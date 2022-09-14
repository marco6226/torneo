using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRPatrocinador
    {
        public bool CrearPatrocinador(Patrocinador patrocinador);
        public Patrocinador BuscarPatrocinador(int id);
        public bool ActualizarPatrocinador(Patrocinador patrocinador);
        public bool EliminarPatrocinador(int id);
        public IEnumerable<Patrocinador> ListarPatrocinadores();
        public List<Patrocinador> ListarPatrocinadores1();
        public Patrocinador BuscarPatrocinadorD(string doc);
    }
}