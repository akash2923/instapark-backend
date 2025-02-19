using instapark.IPmodels;

namespace instapark.IPRepository.Interfaces
{
    public interface IUserRepository
    {
        public Task<ServiceResponseData<List<Users>>> GetUser(GetUser getUser);
        public Task<ServiceResponse> SignUp(SignUp signUp);
        public Task<ServiceResponse> BookingDetails(BookingDetails bookingDetails);

    }
}
