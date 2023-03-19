using CaseVotaRestaurante.Domain.Entities;
using CaseVotaRestaurante.Domain.Interface;
using CaseVotaRestaurante.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Infra.Data.Repository
{
    public class VoteRespository : IVoteRepository
    {
        ApplicationDbContext _voteRepository;
        public VoteRespository(ApplicationDbContext context)
        {
            _voteRepository = context;
        }

        public async Task<Vote> CreateVoteAsync(Vote vote)
        {
            _voteRepository.Add(vote);
            await _voteRepository.SaveChangesAsync();
            return vote;
        }

        public async Task<IEnumerable<Vote>> GetAllVoteAsync()
        {
            return await _voteRepository.Votes.ToListAsync();
        }
        
    }
}
