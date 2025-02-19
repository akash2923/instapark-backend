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
        
        [HttpPost]
        [Route("signup")]
        public async Task<IActionResult> SignUp(SignUp signUp)
        {
            var result = await userService.SignUp(signUp);
            return result.ToActionResult();
        }
        [HttpPost]
        [Route("Booking")]
        public async Task<IActionResult> BookingDetails(BookingDetails bookingDetails)
        {
            var result = await userService.BookingDetails(bookingDetails);
            return result.ToActionResult();
        }



    }
}
