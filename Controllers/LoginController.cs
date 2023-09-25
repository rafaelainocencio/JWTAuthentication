using ApiAuth.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] User model)
        {
            var user = UserRepository.Get(model.UserName, model.Password);

            if (user == null)
            {
                return NotFound("Usuário ou senha inválidos!");
            }
            else
            {
                var token = TokenService.GenerateToken(user);

                user.Password = "";
                return new
                {
                    user = user,
                    token = token,
                };
            }
        }
    }
}
