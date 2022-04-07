using System.ComponentModel.DataAnnotations;

namespace MVChallenge.Models
{
    public class CasaShow
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Endereco {get; set;}
        public bool Status {get; set;}
    }
}