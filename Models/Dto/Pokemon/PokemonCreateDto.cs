using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using pokeapi.Models;

namespace pokeapi.Dto
{
    public class PokemonCreateDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Name has to be a minimum of 3 letters")]
        public string Name { get; set; }
        
        [Required]
        public int TypeId { get; set; }     
    }
}