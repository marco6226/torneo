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
    public class DetailsModel : PageModel
    {
        //Atributos
        private readonly IRPatrocinador _repoPat;

        [BindProperty]
        public Patrocinador Patrocinador {get;set;}

        //Metodos
        //Constructor
        public DetailsModel(IRPatrocinador repoPat)
        {
            this._repoPat= repoPat;
        }

        public ActionResult OnGet(int id)
        {
            Patrocinador= _repoPat.BuscarPatrocinador(id);
            return Page();
        }
    }
}
