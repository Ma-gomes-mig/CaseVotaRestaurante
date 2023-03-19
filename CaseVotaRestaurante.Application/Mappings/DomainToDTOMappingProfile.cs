using AutoMapper;
using CaseVotaRestaurante.Application.DTOs;
using CaseVotaRestaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<People, PeopleDTO>().ReverseMap();
            CreateMap<Vote, VoteDTO>().ReverseMap();
            CreateMap<Restaurant, RestaurantDTO>().ReverseMap();
        }
    }
}
