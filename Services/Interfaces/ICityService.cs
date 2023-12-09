using pokeapi.Models.Dto;

namespace pokeapi.Services.Interfaces
{
    public interface ICityService
    {
        List<CityDto> GetAll();
        CityDto GetById(int id);
    }
}