using ShowHouse.Domain.Entities;

namespace ShowHouse.Domain.Entities
{
    public sealed class Home : Entity
    {
        public Event? Evento {get; set;}

        public ShowHouseEvent? ShowHouseEvent {get; set;}

    }
}