using System.ComponentModel.DataAnnotations;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Application.DTO
{
    public class ShowHouseEventDTO
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "Name is required")]
        [MinLength(3)]
        public string Name {get; set;}
        [Required(ErrorMessage = "Address is required")]
        [MinLength(3)]
        public string Address {get; set;}
    }
}