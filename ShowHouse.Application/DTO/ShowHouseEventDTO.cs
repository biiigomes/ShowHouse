using System.ComponentModel.DataAnnotations;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Application.DTO
{
    public class ShowHouseEventDTO
    {
        public int Id {get; private set;}
        [Required(ErrorMessage = "Name is required")]
        public string Name {get; private set;}
        [Required(ErrorMessage = "Address os required")]
        public string Address {get; private set;}
        public bool Status {get; private set;}
    }
}