using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ModelsLib.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DbApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DbApiController : ControllerBase
    {
        private readonly DbBookLib.Db _context;
        private readonly IConfiguration _configuration;

        public DbApiController(DbBookLib.Db context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("add/{}")]
        public void Login([FromBody] LoginRequest request)
        {
            
        }

        private string GenerateJwtToken(User user)
        {
            
        }
    }
}
