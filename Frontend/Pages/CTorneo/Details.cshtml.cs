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
    public class DetailsModel : PageModel
    {
        private readonly IRTorneo _repoTor;
        private readonly IRMunicipio _repoMun;

        [BindProperty]
        public Torneo Torneo {get;set;}
        public Municipio Municipio {get;set;}

        public DetailsModel(IRTorneo repoTor, IRMunicipio repoMun)
        {
            this._repoTor= repoTor;
            this._repoMun= repoMun;
        }

        public ActionResult OnGet(int id)
        {
            Torneo=_repoTor.BuscarTorneo(id);
            Municipio= _repoMun.BuscarMunicipio(Torneo.MunicipioId);

            if(Torneo!= null)
            {
                return Page();
            }
            else
            {
                ViewData["Error"]="Torneo no encontrado";
                return Page();
            }
        }
    }
}
