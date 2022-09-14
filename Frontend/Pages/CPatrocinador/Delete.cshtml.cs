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
    public class DeleteModel : PageModel
    {
        //Atributos
        private readonly IRPatrocinador _repoPat;

        [BindProperty]
        public Patrocinador Patrocinador { get; set; }

        //Metodos
        //Constructor

        public DeleteModel(IRPatrocinador repoPat)
        {
            this._repoPat=repoPat;
        }

        //enviar informacion al formulario
        public ActionResult OnGet(int id)
        {
            Patrocinador= _repoPat.BuscarPatrocinador(id);
            if(Patrocinador== null)
            {
                ViewData["Error"]="Patrocinaodr no encontrado";
                return Page();
            }
            return Page();
        }

        public ActionResult OnPost()
        {
            bool funciono= _repoPat.EliminarPatrocinador(Patrocinador.Id);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"]="No es posible eliminar este registro";
                return Page();
            }
        }
    }
}
