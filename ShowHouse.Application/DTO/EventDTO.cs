using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Application.DTO
{
    public class EventDTO
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "Name of event is required")]
        [DisplayName("Event's name")]
        [MinLength(3)]
        public string Name {get; set;}
        [Required(ErrorMessage = "Capacity of event is required")]
        [DisplayName("Event's capacity")]
        public int Capacity{get; set;}
        [Required(ErrorMessage = "Date is required")]
        [DisplayName("Date of Event")]
        [DataType(DataType.Date)]
        public string Date {get; set;}
        [Required(ErrorMessage = "Ticket value is required")]
        [DisplayName("Ticket's value")]
        public double TicketValue{get; set;}
        [Required(ErrorMessage = "Style is required")]
        [DisplayName("Style of the songs")]
        public int StyleId {get; set;}
        public Style Style {get; set;}
        [Required(ErrorMessage = "Show house where the event will happen is required")]
        [DisplayName("Show house of Event")]
        public int ShowHouseId {get; set;}
        public ShowHouseEvent ShowHouse {get; set;}

    }
}