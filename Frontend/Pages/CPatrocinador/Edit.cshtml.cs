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
    public class EditModel : PageModel
    {
        private readonly IRPatrocinador _repoPat;

        [BindProperty]
        public Patrocinador Patrocinador { get; set; }

        public EditModel(IRPatrocinador repoPat)
        {
            this._repoPat =repoPat;
        }

        public ActionResult OnGet(int id)
        {
            Patrocinador= _repoPat.BuscarPatrocinador(id);
            return Page();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            bool funciono= _repoPat.ActualizarPatrocinador(Patrocinador);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"]="No fue posible actualizar el registro";
                return Page();
            }
        }
    }
}
