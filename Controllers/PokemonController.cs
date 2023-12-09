using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pokeapi.Data;
using pokeapi.Dto;
using pokeapi.Models;
using pokeapi.Repositories;
using pokeapi.Services;

namespace pokeapi.Controllers;
    [ApiController]
    [Route("api/[controller]")]
    
    // restrict access to a particular action method or controller
    // to only those users who have been authenticated.
    // if a user want to be authenticated they need to login to the application
    // [Authorize]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService pokemonService;
        public PokemonController(IPokemonService pokemonService)
        {
            this.pokemonService = pokemonService;
        }

        // GET: /api/pokemons?filterOn=Name&filterQuery=Track
        [HttpGet]
        public IActionResult GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery)
        {
            return Ok( new ApiResponse<List<PokemonDto>>{
                StatusCode = 200,
                Message = "Retrieved list of pokemon successfully",
                Data = pokemonService.GetAll(filterOn, filterQuery),
            });
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(new ApiResponse<PokemonDto>
                {
                    StatusCode = 200,
                    Message = "Retrieved pokemon by id successfully",
                    Data = pokemonService.GetById(id)
                }); 
            }
            catch(Exception)
            {
                return NotFound(new ApiResponse<PokemonDto>
                {
                    StatusCode = 404,
                    Message = $"Pokemon with id {id} was not found",
                    Data = pokemonService.GetById(id)
                });
            }            
        }
    }