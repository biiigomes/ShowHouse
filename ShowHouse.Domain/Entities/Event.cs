using System.ComponentModel.DataAnnotations;
using MVChallenge.ShowHouse.Domain.Entities;
using ShowHouse.Domain.Validation;

namespace ShowHouse.Domain.Entities
{
    public sealed class Event : Entity 
    {
        public string Place {get; private set;}
        public int Capacity{get; private set;}
        public DateTime Date {get; private set;}
        public double TicketValue{get; private set;}
        public Style Style {get; private set;}
        public ShowHouseEvent ShowHouse {get; private set;}
        public bool Status {get; private set;}

        public Event(string place, int capacity, double ticketValue, bool status){
            ValidateDomain(place, capacity, ticketValue, status);
        }
        public Event(int id, string place, int capacity, double ticketValue, bool status){
            DomainExceptionValidation.When(id < 1, "Invalid Id value.");
            Id = id;

            ValidateDomain(place, capacity, ticketValue, status);
        }
        public void ValidateDomain(string place, int capacity, double ticketValue, bool status){
            DomainExceptionValidation.When(string.IsNullOrEmpty(place),
                  "Invalid event. Place is required.");
            Place = place;

            DomainExceptionValidation.When(capacity < 5, 
                   "Invalid capacity. More capacity is required.");
            Capacity = capacity;

            DomainExceptionValidation.When(ticketValue <= 0, 
                  "Invalid value. Value is required.");
            TicketValue = ticketValue;

            DomainExceptionValidation.When(status != true,
                  "Invalid status. Status is required.");
            Status = status;

        }
    }
}