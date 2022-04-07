using System;
using System.ComponentModel.DataAnnotations;
using mvc_desafio_master.Models;

namespace MVChallenge.Models
{
    public class Evento
    {
        public int Id{get; set;}
        public string evento {get; set;}
        public int Capacidade{get; set;}
        
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Data {get; set;}
        public float ValorIngresso{get; set;}
        public Estilo Estilo {get; set;}
        public CasaShow CasaShow {get; set;}
        public bool Status {get; set;}
    }
}