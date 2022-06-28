using System.ComponentModel.DataAnnotations;
using ShowHouse.Domain.Entities;
using ShowHouse.Domain.Validation;

namespace ShowHouse.Domain.Entities
{
    public sealed class Event : Entity 
    {
        public string? Name {get; private set;}
        public int? Capacity{get; private set;}
        public string? Date {get; private set;}
        public double? TicketValue{get; private set;}
        public int? StyleId {get; private set;}
        public Style? Style {get; set;}
        public int? ShowHouseId {get; set;}
        public ShowHouseEvent? ShowHouse {get; set;}
        public bool? Status {get; set;}

        public Event(string name, int capacity, string date, double ticketValue, bool status){
            ValidateDomain(name, capacity, date, ticketValue, status);
        }
        public Event(int id, string name, int capacity, string date, double ticketValue, bool status){
            DomainExceptionValidation.When(id < 1, "Invalid Id value.");
            Id = id;

            ValidateDomain(name, capacity, date, ticketValue, status);
        } 

        public void ValidateDomain(string name, int capacity, string date, double ticketValue, bool status){
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                  "Invalid event. Place is required.");
            Name = name;

            DomainExceptionValidation.When(capacity < 5, 
                   "Invalid capacity. More capacity is required.");
            Capacity = capacity;

            DomainExceptionValidation.When(string.IsNullOrEmpty(date), 
                   "Invalid date. Date is required");
            Date = date;

            DomainExceptionValidation.When(ticketValue <= 0, 
                  "Invalid value. Value is required.");
            TicketValue = ticketValue;

            DomainExceptionValidation.When(status != true,
                  "Invalid status. Status is required.");
            Status = status;

        }
    }
}