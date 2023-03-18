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
    public class RestaurantRepository : IRestaurantRepository
    {
        ApplicationDbContext _restaurantContext;
        public RestaurantRepository(ApplicationDbContext context)
        {
            _restaurantContext = context;
        }       

        public async Task<IEnumerable<Restaurant>> GetAllRestaurantAsync()
        {
            return await _restaurantContext.Restaurants.ToListAsync();
        }

        public async Task<Restaurant> GetRestaurantByIdAsync(int? id)
        {
            return await _restaurantContext.Restaurants.FindAsync(id);
        }

        public async Task<Restaurant> CreateAsync(Restaurant restaurant)
        {
            _restaurantContext.Add(restaurant);
            await _restaurantContext.SaveChangesAsync();
            return restaurant;
        }

        public async Task<Restaurant> DeleteAsync(Restaurant restaurant)
        {
            _restaurantContext.Remove(restaurant);
            await _restaurantContext.SaveChangesAsync();
            return restaurant;
        }

        public async Task<Restaurant> UpdateAsync(Restaurant restaurant)
        {
            _restaurantContext.Update(restaurant);
            await _restaurantContext.SaveChangesAsync();
            return restaurant;
        }
    }
}
