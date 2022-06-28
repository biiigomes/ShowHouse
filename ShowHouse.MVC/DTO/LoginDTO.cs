using System.ComponentModel.DataAnnotations;

namespace mvc_desafio_master.DTO
{
    public class LoginDTO
    {
        [Required]
        public int Id {get; set;}

        [Required(ErrorMessage = "Precisa-se de um nome")]
        public string Nome {get; set;}

        [Required(ErrorMessage = "Precisa-se de um nome para o usuário")]
        public string UserName{get; set;}
        
        [Required(ErrorMessage = "Precisa-se de uma senha")]
        public string Senha{get; set;}
        public bool Status{get; set;}
    }
}