using JwtAuthenticationDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtAuthenticationDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login(LoginModel model)
        {
            if (model.Username == "admin" && model.Password == "admin123")
            {
                var token = GenerateJwtToken(model.Username);

                return Ok(new
                {
                    Token = token
                });
            }

            return Unauthorized("Invalid Username or Password");
        }

        private string GenerateJwtToken(string username)
        {
           var claims = new[]
{
    new Claim(ClaimTypes.Name, username),
    new Claim(ClaimTypes.Role, "Admin")
};

           var key = new SymmetricSecurityKey(
    Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));

            var credentials = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "MyAuthServer",
                audience: "MyApiUsers",
                claims: claims,
                expires: DateTime.Now.AddSeconds(20),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        private readonly IConfiguration _configuration;

public AuthController(IConfiguration configuration)
{
    _configuration = configuration;
}
    }
}