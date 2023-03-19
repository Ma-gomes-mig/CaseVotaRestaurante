using CaseVotaRestaurante.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Application.Interfaces
{
    public interface IVoteService
    {
        Task<IEnumerable<VoteDTO>> GetAllVoteAsync();
        Task CreateVoteAsync(VoteDTO voteDto);
    }
}
