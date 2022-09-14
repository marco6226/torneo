using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio

{
    public class Deportista
    {        
        //Propiedades
        public int Id {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio, necestimos su documento de identidad")]
        [MaxLength(15, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(4, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        [RegularExpression("[0-9]*", ErrorMessage="Solo puede ingresar valores numericos")]
        public string Documento {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(4, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Solo puede ingresar letras")]
        public string Nombres {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(4, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Solo puede ingresar letras")]
        public string Apellidos {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(9, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(4, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Solo puede ingresar letras")]
        public string Género {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(25, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(4, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Solo puede ingresar letras")]
        public string Modalidad {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento {get;set;}

        [Required(ErrorMessage="Este campo obligatorio")]
        [MaxLength(4, ErrorMessage="el campo {0} debe tener máximo {1} caracteres")]
        [MinLength(2, ErrorMessage="el campo {0} debe tener mínimo {1} caracteres")]
        public string Rh {get;set;}
        
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(4, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string EPS {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(4, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        [RegularExpression("[0-9]*", ErrorMessage="Solo puede ingresar valores numericos")]
        public string Celular {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(10, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Correo {get;set;}

        // Llave foránea relacionada con equipo
        [Required(ErrorMessage="Este campo es obligatorio, por favor revise el ID del equipo relacionado al deportista")]
        public int EquipoId {get;set;}
    }
}