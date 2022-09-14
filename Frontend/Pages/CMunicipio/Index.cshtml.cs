using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CMunicipio
{
    public class IndexModel : PageModel
    {
        //Atributos
        private readonly IRMunicipio _repoMunicipio;
        public IEnumerable<Municipio> Municipios {get;set;}

        //Metodos
        //Constructor
        public IndexModel(IRMunicipio repoMunicipio)
        {
            this._repoMunicipio=repoMunicipio;
        }

        //Enivar vistas y/o valores  al usuario 
        public void OnGet()
        {
            Municipios=_repoMunicipio.ListarMunicipios();
        }
    }
}
