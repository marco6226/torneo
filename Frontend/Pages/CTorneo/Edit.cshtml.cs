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
    public class EditModel : PageModel
    {
        private readonly IRTorneo _repoTor;
        private readonly IRMunicipio _repoMun;

        [BindProperty]
        public Torneo Torneo { get; set; }

        public IEnumerable<Municipio> Municipios {get;set;}

        public EditModel(IRTorneo repoTor, IRMunicipio repoMun)
        {
            this._repoMun= repoMun;
            this._repoTor= repoTor;
        }       

        public ActionResult OnGet(int id)
        {
            Torneo= _repoTor.BuscarTorneo(id);
            if(Torneo!=null)
            {
                Municipios= _repoMun.ListarMunicipios();
                return Page();
            }
            else
            {
                Municipios= _repoMun.ListarMunicipios();
                ViewData["Error"]="Torneo no encontrado";
                return Page();
            }           
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                Municipios= _repoMun.ListarMunicipios();
                return Page();
            }
            //Municipios= _repoMun.ListarMunicipios();
            bool funciono= _repoTor.ActualizarTorneo(Torneo);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Municipios= _repoMun.ListarMunicipios();
                ViewData["Error"]="Ya hay registrado un Torneo con el nombre: " + Torneo.Nombre;
                return Page();
            }
        }
    }
}
