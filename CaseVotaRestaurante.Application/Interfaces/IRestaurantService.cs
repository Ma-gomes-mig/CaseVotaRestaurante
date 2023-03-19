using CaseVotaRestaurante.Application.DTOs;
using CaseVotaRestaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Application.Interfaces
{
    public interface IRestaurantService
    {
        Task<IEnumerable<RestaurantDTO>> GetAllRestaurantAsync();
        Task<RestaurantDTO> GetRestaurantByIdAsync(int? id);



        Task CreateAsync(RestaurantDTO restaurantDto);
        Task UpdateAsync(RestaurantDTO restaurantDto);
        Task DeleteAsync(int? id);
    }
}
