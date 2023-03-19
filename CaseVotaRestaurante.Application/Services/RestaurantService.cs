using AutoMapper;
using CaseVotaRestaurante.Application.DTOs;
using CaseVotaRestaurante.Application.Interfaces;
using CaseVotaRestaurante.Domain.Entities;
using CaseVotaRestaurante.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Application.Services
{
    public class RestaurantService : IRestaurantService
    {
        private IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public RestaurantService(IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RestaurantDTO>> GetAllRestaurantAsync()
        {
            var restaurantEtity = await _restaurantRepository.GetAllRestaurantAsync();
            return _mapper.Map<IEnumerable<RestaurantDTO>>(restaurantEtity);
        }

        public async Task<RestaurantDTO> GetRestaurantByIdAsync(int? id)
        {
            var restaurantEntity = await _restaurantRepository.GetRestaurantByIdAsync(id);
            return _mapper.Map<RestaurantDTO>(restaurantEntity); 
        }

        public async Task CreateAsync(RestaurantDTO restaurantDto)
        {
            var restaurantEntity = _mapper.Map<Restaurant>(restaurantDto);
            await _restaurantRepository.CreateAsync(restaurantEntity);
            
        }

        public async Task UpdateAsync(RestaurantDTO restaurantDto)
        {
            var restaurantEntity = _mapper.Map<Restaurant>(restaurantDto);
            await _restaurantRepository.UpdateAsync(restaurantEntity);
            
        }

        public async Task DeleteAsync(int? id)
        {
            var restaurantEntity = _restaurantRepository.GetRestaurantByIdAsync(id).Result;
            await _restaurantRepository.DeleteAsync(restaurantEntity);
        }
    }
}
