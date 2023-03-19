using CaseVotaRestaurante.Application.DTOs;
using CaseVotaRestaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Application.Interfaces
{
    public interface IPeopleService
    {
        Task<IEnumerable<PeopleDTO>> GetAllPeopleAsync();
        Task<PeopleDTO> GetPeopleByIdAsync(int? id);

        Task CreateAsync(PeopleDTO peopleDto);
        Task UpdateAsync(PeopleDTO peopleDto);
        Task DeleteAsync(int? id);
    }
}
