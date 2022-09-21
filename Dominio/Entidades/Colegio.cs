using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Colegio
    {        
        //Propiedades
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(10, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(9, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Nit {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(10, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string RazonSocial {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(24, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(12, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Direccion {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(12, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(10, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Telefono {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(14, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(6, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Modalidad {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(14, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(8, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Licencia {get;set;}

        /*   //llave foranea para la relacion con Arbitro
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int ArbitroId {get;set;} */
    }
}