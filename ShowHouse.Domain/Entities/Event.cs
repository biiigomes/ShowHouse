using System.ComponentModel.DataAnnotations;
using ShowHouse.Domain.Entities;
using ShowHouse.Domain.Validation;

namespace ShowHouse.Domain.Entities
{
    public sealed class Event : Entity 
    {
        public string Name {get; private set;}
        public int Capacity{get; private set;}
        public string Date {get; private set;}
        public double TicketValue{get; private set;}
        public int StyleId {get; set;}
        public Style Style {get; set;}
        public int ShowHouseId {get; set;}
        public ShowHouseEvent ShowHouse {get; set;}

        public Event(string name, int capacity, string date, double ticketValue, int styleId, int showHouseId){
            ValidateDomain(name, capacity, date, ticketValue, styleId, showHouseId);
        }
        public Event(int id, string name, int capacity, string date, double ticketValue, int styleId, int showHouseId){
            DomainExceptionValidation.When(id < 0, "Invalid Id value.");
            Id = id;

            ValidateDomain(name, capacity, date, ticketValue,  styleId, showHouseId);
        } 

        public void Update(string name, int capacity, string date, double ticketValue, int styleId, int showHouseId)
        {
           ValidateDomain(name, capacity, date, ticketValue,  styleId, showHouseId);
           StyleId = styleId;
           ShowHouseId = showHouseId;
        }

        public void ValidateDomain(string name, int capacity, string date, double ticketValue,  int styleId, int showHouseId){
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



        }
    }
}