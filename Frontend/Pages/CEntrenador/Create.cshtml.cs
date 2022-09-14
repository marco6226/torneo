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
    public class CreateModel : PageModel
    {
        private readonly IREntrenador _repoEntrenador;
        private readonly IREquipo _repoEquipo;

        [BindProperty]
        public Entrenador Entrenador {get;set;}   
        public IEnumerable<Equipo> Equipos {get;set;}

        //Constructor
        public CreateModel(IREquipo repoEquipo, IREntrenador repoEntrenador)
        {
            this._repoEquipo= repoEquipo;
            this._repoEntrenador= repoEntrenador;
        }

        public ActionResult OnGet()
        {
            Equipos= _repoEquipo.ListarEquipos();
            return Page();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                Equipos= _repoEquipo.ListarEquipos();
                return Page();
            }
            
            bool funciono= _repoEntrenador.CrearEntrenador(Entrenador);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Equipos= _repoEquipo.ListarEquipos();
                ViewData["Error"]="No fue posible crear el registro, favor verificar duplicidad en los campos Documento y Equipo";
                return Page();
            }            
            
        }
    }
}
