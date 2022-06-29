using MediatR;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Application.Events.Command
{
    public class EventRemoveCommand : IRequest<Event>
    {
        public int Id {get; set;}
        public EventRemoveCommand(int id)
        {
            Id = id;
        }
    }
}