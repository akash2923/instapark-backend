using instapark.Api.Extensions;
using instapark.IPmodels;
using instapark.IPservices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace instapark.Controllers
{
    [ApiController]
    [Route("/User")]
    public class UserController(IUserService userService) : ControllerBase
    {
        //[HttpPost]
        //[Route("signup")]
        //public async Task<IActionResult> GetUser(GetUser getUser)
        //{
        //    var result = await userService.GetUser(getUser);
        //    return result.ToActionResult();
        //}
        [HttpPost]
        [Route("signup")]
        public async Task<IActionResult> SignUp(SignUp signUp)
        {
            var result = await userService.SignUp(signUp);
            return result.ToActionResult();
        }



    }
}
