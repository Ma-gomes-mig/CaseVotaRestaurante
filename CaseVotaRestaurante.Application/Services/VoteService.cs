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
    public class VoteService : IVoteService
    {
        private IVoteRepository _voteRepository;
        private readonly IMapper _mapper;
        public VoteService(IVoteRepository voteRepository, IMapper mapper)
        {
            _voteRepository = voteRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VoteDTO>> GetAllVoteAsync()
        {
            var voteEntity = await _voteRepository.GetAllVoteAsync();
            return _mapper.Map<IEnumerable<VoteDTO>>(voteEntity);
        }

        public async Task CreateVoteAsync(VoteDTO voteDto)
        {
            var voteEntity = _mapper.Map<Vote>(voteDto);
            await _voteRepository.CreateVoteAsync(voteEntity);
        }
    }
}
