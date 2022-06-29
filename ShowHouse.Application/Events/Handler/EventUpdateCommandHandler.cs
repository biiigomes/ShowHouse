using MediatR;
using ShowHouse.Application.Events.Command;
using ShowHouse.Domain.Entities;
using ShowHouse.Domain.Interfaces;

namespace ShowHouse.Application.Events.Handler
{
    public class EventUpdateCommandHandler : IRequestHandler<EventUpdateCommand, Event>
    {
        private readonly IEventRepository _eventRepository;

        public EventUpdateCommandHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository ??
            throw new ArgumentNullException(nameof(eventRepository));   
        }
        public async Task<Event> Handle(EventUpdateCommand request, CancellationToken cancellationToken)
        {
            var events = await _eventRepository.GetByIdAsync(request.Id);

            if(events == null)
            {
                throw new ApplicationException("$Entity could not be found");
            }
            else
            {
                events.Update(request.Name, request.Capacity, request.Date, request.TicketValue, request.ShowHouseId, request.StyleId, request.Status);
                return await _eventRepository.UpdateAsync(events);
            }
        }
    }
}