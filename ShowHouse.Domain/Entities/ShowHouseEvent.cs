using System.ComponentModel.DataAnnotations;
using ShowHouse.Domain.Validation;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Domain.Entities
{
    public sealed class ShowHouseEvent : Entity
    {
        public string Name {get; private set;}
        public string Address {get; private set;}
        public ICollection<Event> Events {get; set;}
        public ShowHouseEvent(string name, string address)
        {
            ValidateDomain(name, address);
        }
        public ShowHouseEvent(
            int id,
            string name,
            string address)
        {
            DomainExceptionValidation.When(id <= 0, "Invalid Id value.");
            Id = id;
            ValidateDomain(name, address);
        }
        public void ValidateDomain(string name, string address)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), 
                    "Invalid name. The name is required.");
            Name = name;

            DomainExceptionValidation.When(string.IsNullOrEmpty(address),
                    "Invalid address. Address is required.");
            Address = address;
        }
    }
}