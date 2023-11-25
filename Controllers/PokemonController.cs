using Microsoft.AspNetCore.Mvc;
using pokeapi.Models;
using pokeapi.Services;

namespace pokeapi.Controllers;
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService pokemonService;
        public PokemonController(IPokemonService pokemonService)
        {
            this.pokemonService = pokemonService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new ApiResponse<List<Pokemon>>
            {
                StatusCode = 200,
                Message = "Retrieved list of pokemon successfully",
                Data = pokemonService.getAll()
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(new ApiResponse<Pokemon>
                {
                    StatusCode = 200,
                    Message = "Retrieved pokemon by id successfully",
                    Data = pokemonService.getById(id)
                });
            }
            catch(Exception e)
            {    
                return NotFound(new ApiResponse<Pokemon>
                {
                    StatusCode = 404,
                    Message = e.Message,
                    Data = null
                });
            }
        }
    }