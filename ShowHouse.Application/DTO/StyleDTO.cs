using System.ComponentModel.DataAnnotations;

namespace ShowHouse.Application.DTO
{
    public class StyleDTO
    {
        public int Id {get; set;}
        [Required]
        public string MusicalStyle{get; set;}
        [Required]
        public string ImagePath {get; set;}
    }
}