using MediatR;
using ShowHouse.Application.Events.Command;
using ShowHouse.Domain.Entities;
using ShowHouse.Domain.Interfaces;

namespace ShowHouse.Application.Events.Handler
{
    public class EventCreateCommandHandler : IRequestHandler<EventCreateCommand, Event>
    {
        private readonly IEventRepository _eventRepository;

        public EventCreateCommandHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public async Task<Event> Handle(EventCreateCommand request, 
               CancellationToken cancellationToken)
        {
            var events = new Event(request.Name, request.Capacity, request.Date, request.TicketValue, request.ShowHouseId, request.StyleId, request.Status);

            if(events == null)
            {
                throw new ApplicationException($"Error creating entity");
            }
            else
            {
                events.ShowHouseId = request.ShowHouseId;
                events.StyleId = request.StyleId;
                return await _eventRepository.CreateAsync(events);
            }
        }
    }
}