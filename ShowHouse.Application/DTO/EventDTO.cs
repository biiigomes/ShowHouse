using System.ComponentModel.DataAnnotations;

namespace ShowHouse.Application.DTO
{
    public class EventDTO
    {
        public int Id {get; private set;}
        [Required(ErrorMessage = "Name of event is required")]
        public string Name {get; private set;}
        [Required(ErrorMessage = "Capacity of event is required")]
        public int Capacity{get; private set;}
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string Date {get; private set;}
        [Required(ErrorMessage = "Ticket value is required")]
        public double TicketValue{get; private set;}
        [Required(ErrorMessage = "Style is required")]
        public int StyleId {get; private set;}
        [Required(ErrorMessage = "Show house where the event will happen is required")]
        public int ShowHouseId {get; set;}

    }
}