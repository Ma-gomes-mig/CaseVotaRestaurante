using AutoMapper;
using CaseVotaRestaurante.Application.DTOs;
using CaseVotaRestaurante.Application.Interfaces;
using CaseVotaRestaurante.Domain.Entities;
using CaseVotaRestaurante.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Application.Services
{
    public class PeopleService : IPeopleService
    {
        private IPeopleRepository _peopleRepository;
        private readonly IMapper _mapper;
        public PeopleService(IPeopleRepository peopleRepository, IMapper mapper)
        {
            _peopleRepository = peopleRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PeopleDTO>> GetAllPeopleAsync()
        {
            var peopleEntity = await _peopleRepository.GetAllPeopleAsync();
            return _mapper.Map<IEnumerable<PeopleDTO>>(peopleEntity);
        }

        public async Task<PeopleDTO> GetPeopleByIdAsync(int? id)
        {
            var peopleEntity = await _peopleRepository.GetPeopleByIdAsync(id);
            return _mapper.Map<PeopleDTO>(peopleEntity);
        }

        public async Task CreateAsync(PeopleDTO peopleDto)
        {
            var peopleEntity = _mapper.Map<People>(peopleDto);
            await _peopleRepository.CreateAsync(peopleEntity);
            
        }

        public async Task UpdateAsync(PeopleDTO peopleDto)
        {
            var peopleEntity = _mapper.Map<People>(peopleDto);
            await _peopleRepository.UpdateAsync(peopleEntity);
            
        }

        public async Task DeleteAsync(int? id)
        {
            var peopleEntity = _peopleRepository.GetPeopleByIdAsync(id).Result;
            await _peopleRepository.DeleteAsync(peopleEntity);
        }
    }
}
