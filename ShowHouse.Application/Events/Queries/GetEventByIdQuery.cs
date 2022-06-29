using MediatR;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Application.Events.Queries
{
    public class GetEventByIdQuery : IRequest<Event>
    {
        public int Id {get; set;}
        public GetEventByIdQuery(int id)
        {
            Id = id;
        }
    }
}