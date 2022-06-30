using AutoMapper;
using ShowHouse.Application.DTO;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Application.Mapping
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<ShowHouseEvent, ShowHouseEventDTO>().ReverseMap();
            CreateMap<Event, EventDTO>().ReverseMap();
            CreateMap<Style, StyleDTO>().ReverseMap();
        }
    }
}