using System;
using pokeapi.Data;
using pokeapi.Models.Domain;
using pokeapi.Repositories.Interfaces;

namespace pokeapi.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext context;

        public CityRepository(DataContext context)
        {
            this.context = context;
        }
        public List<City> GetAll()
        {
            return context.Cities.ToList();
        }

        public City GetById(int id)
        {
            return context.Cities.FirstOrDefault(x => x.id == id);
        }
    }
}