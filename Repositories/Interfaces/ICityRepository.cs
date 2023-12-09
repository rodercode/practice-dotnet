using pokeapi.Models.Domain;

namespace pokeapi.Repositories.Interfaces
{
    public interface ICityRepository
    {
        List<City> GetAll();
        City GetById(int id);
    }
}