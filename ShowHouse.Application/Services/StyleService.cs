using AutoMapper;
using ShowHouse.Application.DTO;
using ShowHouse.Application.Interfaces;
using ShowHouse.Domain.Interfaces;

namespace ShowHouse.Application.Services
{
    public class StyleService : IStyleService
    {
        private readonly IStyleRepository _styleRepository;
        private readonly IMapper _mapper;

        public StyleService(IStyleRepository styleRepository, IMapper mapper)
        {
            _styleRepository = styleRepository;
            _mapper = mapper;
        }

        public async Task<StyleDTO> GetById(int? id)
        {
            var styleRepository = await _styleRepository.GetById(id);
            return _mapper.Map<StyleDTO>(styleRepository);
        }

        public async Task<IEnumerable<StyleDTO>> GetStyles()
        { 
            var styleRepository = await _styleRepository.GetStyles();
            return _mapper.Map<IEnumerable<StyleDTO>>(styleRepository);
        }
    }
}