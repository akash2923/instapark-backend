
using instapark.IPmodels;

namespace instapark.IPservices.Interfaces
{
    public interface IUserService
    {
        public Task<ServiceResponseData<List<Users>>> GetUser(GetUser getUser);
        public Task<ServiceResponse> SignUp(SignUp signUp);
        public Task<ServiceResponse> BookingDetails(BookingDetails bookingDetails);


    }
}
