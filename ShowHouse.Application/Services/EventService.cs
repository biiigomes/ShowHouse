using AutoMapper;
using MediatR;
using ShowHouse.Application.DTO;
using ShowHouse.Application.Interfaces;
using ShowHouse.Domain.Entities;
using ShowHouse.Domain.Interfaces;

namespace ShowHouse.Application.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<EventDTO> GetById(int? id)
        {
            var eventEntity = await _eventRepository.GetByIdAsync(id);
            return _mapper.Map<EventDTO>(eventEntity);
        }

        public async Task<IEnumerable<EventDTO>> GetEvents()
        {
            var eventsEntity = await _eventRepository.GetEventsAsync();
            return _mapper.Map<IEnumerable<EventDTO>>(eventsEntity);

        }

        public async Task Add(EventDTO eventDTO)
        {
            var eventEntity = _mapper.Map<Event>(eventDTO);
            await _eventRepository.CreateAsync(eventEntity);
        }

        public async Task Update(EventDTO eventDTO)
        {
            var eventEntity = _mapper.Map<Event>(eventDTO);
            await _eventRepository.UpdateAsync(eventEntity);
        }

        public async Task Remove(int? id)
        {
            var eventEntity = _eventRepository.GetByIdAsync(id).Result;
            await _eventRepository.RemoveAsync(eventEntity);
        }
    }
}