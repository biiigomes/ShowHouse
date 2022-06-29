using MediatR;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Application.Events.Command
{
    public abstract class EventCommand : IRequest<Event>
    {
        public string Name {get; set;}
        public int Capacity{get; set;}
        public string Date {get; set;}
        public double TicketValue{get; set;}
        public int StyleId {get; set;}
        public int ShowHouseId {get; set;}
        public bool Status {get; set;}

    }
}