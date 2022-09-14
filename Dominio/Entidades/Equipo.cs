using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dominio
{
    public class Equipo
    {
        //Propiedades
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(4, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Nombre {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(10, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Modalidades {get;set;}

        //Propiedad navigacional para la relación con Entrenado
        [Required(ErrorMessage="Este campo es obligatorio")]
        public Entrenador Tecnico  {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [RegularExpression("[0-9]*", ErrorMessage="Solo puede ingresar valores numericos")]
        public int Jugadores {get;set;}

        //llave foranea para la relacion con Patrocinador
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int PatrocinadorId {get;set;}

        //relacion con TorneoEquipo
        public List<TorneoEquipo> TorneoEquipos {get;set;}

    }
}