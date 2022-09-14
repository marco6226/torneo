using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Torneo
    {
        //Propiedades
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres mi rey")]
        [MinLength(4, ErrorMessage="El campo {0} debe tener al menos {1} caracteres mi rey")]
        public string Nombre {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(12, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres mi rey")]
        [MinLength(6, ErrorMessage="El campo {0} debe tener al menos {1} caracteres mi rey")]
        public string Categoria {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres mi rey")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener al menos {1} caracteres mi rey")]
        public string Modalidad {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaFin {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        public int Equipos {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres mi rey")]
        [MinLength(15, ErrorMessage="El campo {0} debe tener al menos {1} caracteres mi rey")]
        public string Fixture {get;set;}

        // Relacion con municipio
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int MunicipioId {get;set;}
        public Municipio Municipio {get;set;}

        // Propiedad navigacional para la relacion con unidaddeportiva
        public List<UnidadDeportiva> UnidadDeportivas { get; set; }
    }
}