using System.ComponentModel.DataAnnotations;
using ShowHouse.Domain.Validation;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Domain.Entities
{
    public sealed class ShowHouseEvent : Entity
    {
        public string Name {get; private set;}
        public string Address {get; private set;}
        public bool Status {get; private set;}
        public ICollection<Event> Events {get; set;}
        public ShowHouseEvent(string name, string address, bool status)
        {
            ValidateDomain(name, address, status);
        }
        public ShowHouseEvent(
            int id,
            string name,
            string address,
            bool status)
        {
            DomainExceptionValidation.When(id < 1, "Invalid Id value.");
            Id = id;
            ValidateDomain(name, address, status);
        }
        public void ValidateDomain(string name, string address, bool status)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), 
                    "Invalid name. The name is required.");
            Name = name;

            DomainExceptionValidation.When(string.IsNullOrEmpty(address),
                    "Invalid address. Address is required.");
            Address = address;

            DomainExceptionValidation.When(status != true, 
                    "Invalid status. Status is required.");
            Status = status;
        }
    }
}