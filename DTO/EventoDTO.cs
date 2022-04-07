using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_desafio_master.DTO
{
    public class EventoDTO
    {
        [Required]
        public int Id{get; set;}

        [Required(ErrorMessage ="Nome do evento é obrigatório")]
        public string evento {get; set;}

        [Required(ErrorMessage ="Capacidade do evento é obrigatório")]
        public int Capacidade{get; set;}

        [Required(ErrorMessage ="Data do evento é obrigatória")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Data {get; set;}
        
        [Required(ErrorMessage = "Valor do Ingresso é obrigatório")]
        public float ValorIngresso{get; set;}

        [Required(ErrorMessage = "Estilo é obrigatório")]
        public int EstiloID{get; set;}

        [Required(ErrorMessage = "A casa onde o show ocorrerá é obrigatória")]
        public int CasaShowID {get; set;}

    }
}