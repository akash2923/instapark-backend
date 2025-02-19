
using instapark.IPmodels;
using instapark.IPRepository.Interfaces;
using instapark.IPservices.Interfaces;

namespace instapark.IPservices
{
    public class UserService(IUserRepository userRepository):IUserService
    {
         public async Task<ServiceResponseData<List<Users>>> GetUser(GetUser getUser)
        {
            return await userRepository.GetUser(getUser);

        }
        public async Task<ServiceResponse> SignUp(SignUp signUp)
        {
            return await userRepository.SignUp(signUp);
        }
        public async Task<ServiceResponse> BookingDetails(BookingDetails bookingDetails)
        {
            return await userRepository.BookingDetails(bookingDetails);
        }



    }
}
