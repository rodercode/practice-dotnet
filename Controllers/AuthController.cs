using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using pokeapi.Dto;

namespace pokeapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        public AuthController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        // POST: /api/auth/login
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto request)
        {
            IdentityUser identityUser = new IdentityUser
            {
                UserName = request.Username,
                Email = request.Username,
            }; 
            
            IdentityResult identityResult = await userManager.CreateAsync(identityUser, request.Password);

            if(identityResult.Succeeded)
            {
                // Add roles to this Usser
                if(request.Roles != null && request.Roles.Any())
                {
                  identityResult = await userManager.AddToRolesAsync(identityUser, request.Roles);
                  
                  if(identityResult.Succeeded)
                  {
                    return Ok("User was registered! Please login.");
                  }               
                }
            }
            return BadRequest("Something went wrong");       
        }
    }
}