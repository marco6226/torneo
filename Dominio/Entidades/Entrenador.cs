using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dominio
{
    public class Entrenador
    {
        //Propiedades
        //[Key]
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        [RegularExpression("[0-9]*", ErrorMessage="Solo puede ingresar valores numericos")]
        public string Documento {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(3, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Solo puede ingresar valores numericos")]
        public string Nombres {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(3, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Solo puede ingresar valores numericos")]
        public string Apellidos {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(3, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        [RegularExpression("[A-Za-z0-9 ]*", ErrorMessage="Solo puede ingresar valores numericos")]
        public string Modalidad {get;set;}

        [Range(3000000000,3509999999, ErrorMessage="Ingrese un numero de celular valido")]
        public string Celular {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.EmailAddress)]
        public string Correo {get;set;} 

        //llave foranea para la relacion con Equipo      
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int EquipoId {get;set;}

    }
}