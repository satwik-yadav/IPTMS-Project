using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthorizationAPI.Model;
using AuthorizationAPI.Provider;
using AuthorizationAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;

namespace AuthorizationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration _config;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AuthController));
        private readonly IUserRepo repo;
        

        public AuthController(IConfiguration config ,IUserRepo _repo)
        {
            _config = config;
            repo = _repo;
        }

        
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] User login)
        {
            AuthRepo auth_repo = new AuthRepo(_config, repo);
            _log4net.Info("Login initiated!");
            IActionResult response = Unauthorized();

            try
            {
                var user = auth_repo.AuthenticateUser(login);
                if (user == null)
                {
                    _log4net.Info("User is not authenticated!");
                    return NotFound();
                }
                else
                {
                    var tokenString = auth_repo.GenerateJSONWebToken(user);
                    response = Ok(new { token = tokenString });
                }

            }

            catch(Exception ex)
            {
                _log4net.Info("Exception " + ex + " occured");

            }

            _log4net.Info("User is authenticated. Returning token generated");
            return response;
        }

    }
}
