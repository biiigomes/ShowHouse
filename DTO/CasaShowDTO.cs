using System.ComponentModel.DataAnnotations;

namespace mvc_desafio_master.DTO
{
    public class CasaShowDTO
    {
        [Required]
        public int Id {get; set;}

        [Required(ErrorMessage = "Nome necessário")]
        public string Nome {get; set;}

        [Required(ErrorMessage = "Endereço necessário")]
        public string Endereco {get; set;}
    }
}