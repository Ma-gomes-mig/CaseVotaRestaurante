using CaseVotaRestaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Domain.Interface
{
    public interface IRestaurantRepository
    {
        Task<IEnumerable<Restaurant>> GetAllRestaurantAsync();
        Task<Restaurant> GetRestaurantByIdAsync(int? id);


        Task<Restaurant> CreateAsync(Restaurant restaurant);
        Task<Restaurant> UpdateAsync(Restaurant restaurant);
        Task<Restaurant> DeleteAsync(Restaurant restaurant);
    }
}
