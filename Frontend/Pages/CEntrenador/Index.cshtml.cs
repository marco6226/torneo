using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CEntrenador
{
    public class IndexModel : PageModel
    {
        //Atributos
        private readonly IREntrenador _repoEntrenador;   
        private readonly IREquipo _repoEquipo;     

        [BindProperty]
        public IEnumerable<Entrenador> Entrenadores {get;set;}
        
        public List<EntrenadorView> EntrenadoresV = new List<EntrenadorView>();
        

        //Metodos
        //Constructor
        public IndexModel(IREntrenador repoEntrenador, IREquipo repoEquipo)
        {
            this._repoEntrenador= repoEntrenador;
            this._repoEquipo= repoEquipo;            
        }

        //Enivar vistas y/o valores  al usuario 
        public void OnGet()
        {
            List<Equipo> lstEquipos= _repoEquipo.ListarEquipos1();
            Entrenadores=_repoEntrenador.ListarEntrenadores();
            EntrenadorView ev=null;

            foreach (var e in Entrenadores)
            {
                ev= new EntrenadorView();
                foreach (var q in lstEquipos)
                {
                    if(e.EquipoId == q.Id)
                    {
                        ev.Equipo= q.Nombre;
                    }
                }
                ev.Id= e.Id;
                ev.Documento= e.Documento;
                ev.Nombres= e.Nombres;
                ev.Apellidos= e.Apellidos;
                //agregar el objeto a la lista
                EntrenadoresV.Add(ev);
            }
        }
    }
}
