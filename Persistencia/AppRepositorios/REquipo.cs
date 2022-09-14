using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public class REquipo:IREquipo
    {
        //atributos
        private readonly AppContext _appContext;

        //Metodos
        //Constructor por defecto
        public REquipo(AppContext appContext)
        {
            this._appContext=appContext;
        }

        public bool CrearEquipo(Equipo equipo)
        {
            bool creado=false;
            try
            {
                this._appContext.Equipos.Add(equipo);
                this._appContext.SaveChanges();
                creado= true;
            }
            catch (System.Exception)
            {                
                creado=false;
            }               
            return creado;
        }

        public Equipo BuscarEquipo(int id)
        {
            return _appContext.Equipos.Find(id);            
        }        

        public bool ActualizarEquipo(Equipo equipo)
        {
            bool actualizado=false;
            var equ= _appContext.Equipos.Find(equipo.Id);
            if(equ != null)
            {                
                try
                {
                    equ.Nombre= equipo.Nombre;
                    equ.Modalidades= equipo.Modalidades;
                    equ.Jugadores=equipo.Jugadores;
                    equ.PatrocinadorId= equipo.PatrocinadorId;                  
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

        public bool EliminarEquipo(int id)
        {
            bool eliminado= false;
            var equ= this._appContext.Equipos.Find(id);
            if(equ != null)
            {
                try
                {
                    this._appContext.Equipos.Remove(equ);
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

        public List<Equipo> ListarEquipos1()
        {
            return this._appContext.Equipos.ToList(); //select * from Municipios
        }

        public IEnumerable<Equipo> ListarEquipos()
        {
            return this._appContext.Equipos;
        }
        
    }
}