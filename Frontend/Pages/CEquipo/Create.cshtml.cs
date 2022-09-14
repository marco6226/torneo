using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CEquipo
{
    public class CreateModel : PageModel
    {
        private readonly IREquipo _repoEquipo;
        private readonly IRPatrocinador _repoPat;

        [BindProperty]
        public Equipo Equipo {get;set;}   
        public IEnumerable<Patrocinador> Patrocinadores {get;set;}

        //Constructor
        public CreateModel(IREquipo repoEquipo, IRPatrocinador repoPat)
        {
            this._repoEquipo= repoEquipo;
            this._repoPat= repoPat;
        }

        public ActionResult OnGet()
        {
            Patrocinadores= _repoPat.ListarPatrocinadores();
            return Page();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                Patrocinadores= _repoPat.ListarPatrocinadores();
                return Page();
            }
            
            bool funciono= _repoEquipo.CrearEquipo(Equipo);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Patrocinadores= _repoPat.ListarPatrocinadores();
                ViewData["Error"]="No se pueden registrar Equipos con el mismo nombre";
                return Page();
            }            
            
        }
    }
}
