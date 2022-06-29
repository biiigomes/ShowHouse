using AutoMapper;
using ShowHouse.Application.DTO;
using ShowHouse.Application.Interfaces;
using ShowHouse.Domain.Entities;
using ShowHouse.Domain.Interfaces;

namespace ShowHouse.Application.Services
{
    public class ShowHouseEventService : IShowHouseEventService
    {
        private readonly IShowHouseEventRepository _showHouseEventRepository;
        private readonly IMapper _mapper;

        public ShowHouseEventService(IShowHouseEventRepository showHouseEventRepository, IMapper mapper)
        {
            _showHouseEventRepository = showHouseEventRepository;
            _mapper = mapper;
        }

        public async Task<ShowHouseEventDTO> GetById(int? id)
        {
            var showHousesEntity = await _showHouseEventRepository.GetById(id);
            return _mapper.Map<ShowHouseEventDTO>(showHousesEntity);
        }

        public async Task<IEnumerable<ShowHouseEventDTO>> GetShowHouses()
        {
            var showHousesEntity = await _showHouseEventRepository.GetShowHouses();
            return _mapper.Map<IEnumerable<ShowHouseEventDTO>>(showHousesEntity);
        }

        public async Task Add(ShowHouseEventDTO showHouseDTO)
        {
            var showHousesEntity = _mapper.Map<ShowHouseEvent>(showHouseDTO);
            await _showHouseEventRepository.Create(showHousesEntity);
        }

        public async Task Update(ShowHouseEventDTO showHouseDTO)
        {
            var showHousesEntity = _mapper.Map<ShowHouseEvent>(showHouseDTO);
            await _showHouseEventRepository.Update(showHousesEntity);
        }
        
        public async Task Remove(int? id)
        {
            var showHousesEntity = _showHouseEventRepository.GetById(id).Result;
            await _showHouseEventRepository.Remove(showHousesEntity);
        }
    }
}