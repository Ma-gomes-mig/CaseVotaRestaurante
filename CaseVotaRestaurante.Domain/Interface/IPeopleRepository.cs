using CaseVotaRestaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Domain.Interface
{
    public interface IPeopleRepository
    {
        Task<IEnumerable<People>> GetAllPeopleAsync();
        Task<People> GetPeopleByIdAsync(int? id);

        Task<People> CreateAsync(People people);
        Task<People> UpdateAsync(People people);
        Task<People> DeleteAsync(People people);
    }
}
