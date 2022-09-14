using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public class REntrenador:IREntrenador
    {
        //atributos
        private readonly AppContext _appContext;

        //Metodos
        //Constructor por defecto
        public REntrenador(AppContext appContext)
        {
            this._appContext=appContext;
        }

        public bool CrearEntrenador(Entrenador entrenador)
        {
            bool creado=false;
            try
            {
                this._appContext.Entrenadores.Add(entrenador);
                this._appContext.SaveChanges();
                creado= true;
            }
            catch (System.Exception)
            {                
                creado=false;
            }               
            return creado;
        }

        public Entrenador BuscarEntrenador(int id)
        {
            return _appContext.Entrenadores.Find(id);            
        }        

        public bool ActualizarEntrenador(Entrenador entrenador)
        {
            bool actualizado=false;
            var ent= _appContext.Entrenadores.Find(entrenador.Id);
            if(ent != null)
            {                
                try
                {
                    ent.Documento= entrenador.Documento;
                    ent.Nombres= entrenador.Nombres;
                    ent.Apellidos= entrenador.Apellidos;
                    ent.Modalidad= entrenador.Modalidad;
                    ent.Celular= entrenador.Celular;
                    ent.Correo= entrenador.Correo;
                    ent.EquipoId= entrenador.EquipoId;           
                    _appContext.SaveChanges();
                    actualizado=true;
                }
                catch(System.Exception)
                {
                    actualizado=false;
                }                              
            }
            return actualizado;
        }

        public bool EliminarEntrenador(int id)
        {
            bool eliminado= false;
            var ent= this._appContext.Entrenadores.Find(id);
            if(ent != null)
            {
                try
                {
                    this._appContext.Entrenadores.Remove(ent);
                    this._appContext.SaveChanges();
                    eliminado= true;
                }
                catch (System.Exception)
                {                    
                   eliminado=false;
                }
            }
            return eliminado;
        }

        public List<Entrenador> ListarEntrenadores1()
        {
            return this._appContext.Entrenadores.ToList(); //select * from Municipios
        }

        public IEnumerable<Entrenador> ListarEntrenadores()
        {
            return this._appContext.Entrenadores;
        }
        
    }
}