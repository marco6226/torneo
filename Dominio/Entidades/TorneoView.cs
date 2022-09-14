using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dominio
{
    public class TorneoView
    {
        //Propiedades

        public int Id {get;set;}       
        public string Nombre {get;set;}        
        public string Categoria {get;set;}        
        public string Modalidad {get;set;}       
        public DateTime FechaInicio {get;set;}
        public DateTime FechaFin {get;set;}       
        public int Equipos {get;set;}       
        public string Fixture {get;set;}
        //Relacion con Municipio       
        public string Municipio {get;set;}
       

        


    }
}