using System.ComponentModel.DataAnnotations;

namespace ShowHouse.Application.DTO
{
    public class EventDTO
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "Name of event is required")]
        [MinLength(3)]
        public string Name {get; set;}
        [Required(ErrorMessage = "Capacity of event is required")]
        public int Capacity{get; set;}
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string Date {get; set;}
        [Required(ErrorMessage = "Ticket value is required")]
        public double TicketValue{get; set;}
        [Required(ErrorMessage = "Style is required")]
        public int StyleId {get; set;}
        [Required(ErrorMessage = "Show house where the event will happen is required")]
        public int ShowHouseId {get; set;}

    }
}