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

        [HttpPost]
        [Route("CloseTheSlot")]
        public async Task<IActionResult> CloseTheSlot(ToCloseTheSlot toCloseTheSlot)
        {
            var result = await userService.CloseTheSlot(toCloseTheSlot);
            return result.ToActionResult();
        }
        [HttpPost]
        [Route("signin")]

        public async Task<IActionResult> CheckUserCredentials(ToCheckUserCredentials toCheckUserCredentials)
        {
            var result = await userService.CheckUserCredentials(toCheckUserCredentials);
            return result.ToActionResult();
        }


    }
}
