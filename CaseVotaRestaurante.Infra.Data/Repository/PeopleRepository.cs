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
    public class PeopleRepository : IPeopleRepository
    {
        ApplicationDbContext _peopleContext;
        public PeopleRepository(ApplicationDbContext context)
        {
            _peopleContext = context;
        }

        public async Task<IEnumerable<People>> GetAllPeopleAsync()
        {
            return await _peopleContext.Peoples.ToListAsync();
        }

        public async Task<People> GetPeopleByIdAsync(int? id)
        {
            return await _peopleContext.Peoples.FindAsync(id);
        }

        public async Task<People> CreateAsync(People people)
        {
            _peopleContext.Add(people);
            await _peopleContext.SaveChangesAsync();
            return people;
        }

        public async Task<People> DeleteAsync(People people)
        {
            _peopleContext.Remove(people);
            await _peopleContext.SaveChangesAsync();
            return people;
        }

        public async Task<People> UpdateAsync(People people)
        {
            _peopleContext.Update(people);
            await _peopleContext.SaveChangesAsync();
            return people;
        }
    }
}
