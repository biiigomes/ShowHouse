using MediatR;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Application.Events.Queries
{
    public class GetEventQuery : IRequest<IEnumerable<Event>>
    {
        
    }
}