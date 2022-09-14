using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class UnidadDeportiva
    {
        // Propiedades
        // [Key]
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(40, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres mi rey")]
        [MinLength(6, ErrorMessage="El campo {0} debe tener al menos {1} caracteres mi rey")]
        public string Nombre {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres mi rey")]
        [MinLength(4, ErrorMessage="El campo {0} debe tener al menos {1} caracteres mi rey")]
        public string Direccion {get;set;}

        // Llave foranea para la relación con torneo
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int TorneoId { get; set; }
    }
}