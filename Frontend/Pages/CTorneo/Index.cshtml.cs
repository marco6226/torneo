using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CTorneo
{
    public class IndexModel : PageModel
    {
        //Atributos
        private readonly IRTorneo _repoTor;
        private readonly IRMunicipio _repoMun;

        [BindProperty]
        public IEnumerable<Torneo> Torneos {get;set;}
        public List<TorneoView> TorneosV = new List<TorneoView>();
        //public Municipio Muni{get;set;}

        //Metodos
        //Constructor
        public IndexModel(IRTorneo repoTor, IRMunicipio repoMun)
        {
            this._repoTor= repoTor;
            this._repoMun=repoMun;
        }

        //Enivar vistas y/o valores  al usuario 
        public void OnGet()
        {
            List<Municipio> lstMunicipios= _repoMun.ListarMunicipios1();
            Torneos=_repoTor.ListarTorneos();
            TorneoView tv=null;

            foreach (var t in Torneos)
            {
                tv=new TorneoView();
                foreach (var m in lstMunicipios)
                {
                    if(t.MunicipioId==m.Id)
                    {
                        tv.Municipio= m.Nombre;
                    }                   
                }
                tv.Id=t.Id;
                tv.Nombre=t.Nombre;
                tv.Categoria= t.Categoria;
                tv.Modalidad=t.Modalidad;
                tv.FechaInicio=t.FechaInicio;
                tv.FechaFin=t.FechaFin;
                tv.Equipos= t.Equipos;
                tv.Fixture= t.Fixture;
                TorneosV.Add(tv);               
            }

        }
    }
}
