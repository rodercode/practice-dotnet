using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using pokeapi.Models.Dto;
using pokeapi.Repositories;
using pokeapi.Repositories.Interfaces;
using pokeapi.Services.Interfaces;

namespace pokeapi.Services
{
    public class CityService : ICityService
    {
        private readonly IMapper mapper;
        private readonly ICityRepository cityRepository;
        public CityService(IMapper mapper, ICityRepository cityRepository)
        {
            this.mapper = mapper;
            this.cityRepository = cityRepository;
        }

        public List<CityDto> GetAll()
        {
            var citiesDomain = cityRepository.GetAll();
            return mapper.Map<List<CityDto>>(citiesDomain);
        }

        public CityDto GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}