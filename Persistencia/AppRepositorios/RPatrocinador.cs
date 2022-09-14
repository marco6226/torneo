using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public class RPatrocinador:IRPatrocinador
    {
        //atributos
        private readonly AppContext _appContext;

        //Metodos
        //Constructor por defecto
        public RPatrocinador(AppContext appContext)
        {
            this._appContext=appContext;
        }

        public bool CrearPatrocinador(Patrocinador patrocinador)
        {
            bool creado=false;
            bool ex= Existe(patrocinador);
            if(!ex)
            {
                try
                {
                    this._appContext.Patrocinadores.Add(patrocinador);
                    this._appContext.SaveChanges();
                    creado= true;
                }
                catch (System.Exception)
                {                
                    creado=false;
                }
            }     
            return creado;
        }

        public Patrocinador BuscarPatrocinador(int id)
        {
            Patrocinador patrocinador= _appContext.Patrocinadores.Find(id);
            return patrocinador;
        }

        public Patrocinador BuscarPatrocinadorD(string doc)
        {
            Patrocinador patrocinador= _appContext.Patrocinadores.FirstOrDefault(p=> p.Documento== doc);
            return patrocinador;
        }

        public bool ActualizarPatrocinador(Patrocinador patrocinador)
        {
            bool actualizado=false;
            var pat= _appContext.Patrocinadores.Find(patrocinador.Id);
            if(pat != null)
            {                
                try
                {
                    pat.Documento= patrocinador.Documento;
                    pat.Nombres= patrocinador.Nombres;
                    pat.Tipo=patrocinador.Tipo;
                    pat.Direccion= patrocinador.Direccion;
                    pat.Telefono= patrocinador.Telefono;
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

        public bool EliminarPatrocinador(int id)
        {
            bool eliminado= false;
            var pat= this._appContext.Patrocinadores.Find(id);
            if(pat != null)
            {
                try
                {
                    this._appContext.Patrocinadores.Remove(pat);
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

        public List<Patrocinador> ListarPatrocinadores1()
        {
            return this._appContext.Patrocinadores.ToList(); //select * from Municipios
        }

        public IEnumerable<Patrocinador> ListarPatrocinadores()
        {
            return this._appContext.Patrocinadores;
        }

        private bool Existe(Patrocinador patrocinador)
        {
            bool ex= false;
            Patrocinador pat= _appContext.Patrocinadores.FirstOrDefault(p=> p.Documento == patrocinador.Documento);
            if(pat != null)
            {
                ex=true;
            }
            return ex;
        }

    }
}