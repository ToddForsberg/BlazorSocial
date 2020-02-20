using System.Linq;
using System.Threading.Tasks;
using BlazorSocial.Shared.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlazorSocial.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private static UserModel LoggedOutUser = new UserModel { IsAuthenticated = false };

        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegisterModel model)
        {
            var newUser = new IdentityUser { UserName = model.Email, Email = model.Email };

            var result = await _userManager.CreateAsync(newUser, model.Password);

            if (result.Succeeded) return Ok(new RegisterResult {Successful = true});
            var errors = result.Errors.Select(x => x.Description);

            return Ok(new RegisterResult { Successful = false, Errors = errors });
        }
    }
}