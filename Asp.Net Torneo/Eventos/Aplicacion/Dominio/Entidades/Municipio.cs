using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Municipio
    {
        // Propiedades
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres mi rey")]
        [MinLength(4, ErrorMessage="El campo {0} debe tener al menos {1} caracteres mi rey")]
        public string Nombre {get;set;}

        // Relacion con torneo, propiedad navigacional
        public List<Torneo> Torneos {get;set;}
    }
}