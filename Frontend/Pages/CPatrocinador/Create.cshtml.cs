using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CPatrocinador
{
    public class CreateModel : PageModel
    {
        // Atributos
        private readonly IRPatrocinador _repoPat;

        [BindProperty]
        public Patrocinador Patrocinador { get; set; }

        //Metodos
        //Constructor
        public CreateModel(IRPatrocinador repoPat)
        {
            this._repoPat= repoPat;
        }

        //enviar informacion o vista al usuario
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            bool funciono= _repoPat.CrearPatrocinador(Patrocinador);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"]= "No puede crear Patrocinadore con documento repetidos";
                return Page();
            }
        }
    }
}
