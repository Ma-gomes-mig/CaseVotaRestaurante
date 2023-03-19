using CaseVotaRestaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Domain.Interface
{
    public interface IVoteRepository
    {
        Task<IEnumerable<Vote>> GetAllVoteAsync();
        Task<Vote> CreateVoteAsync(Vote vote);
    }
}
