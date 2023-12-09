using System;
using Microsoft.AspNetCore.Mvc;
using pokeapi.Models;
using pokeapi.Models.Dto;
using pokeapi.Services.Interfaces;

namespace pokeapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ICityService cityService;
        public CityController(ICityService cityService)
        {
            this.cityService = cityService;
        }

        [HttpGet]
        public IActionResult GetAll( )
        {
            return Ok( new ApiResponse<List<CityDto>>{
                StatusCode = 200,
                Message = "Retrieved list of cities was successful",
                Data = cityService.GetAll(),
            });
        }
    }
}