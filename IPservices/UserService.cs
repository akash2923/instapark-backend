
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

        public async Task<ServiceResponseData<List<CloseTheSlot>>> CloseTheSlot(ToCloseTheSlot toCloseTheSlot)
        {
            return await userRepository.CloseTheSlot(toCloseTheSlot);
        }
        public async Task<ServiceResponseData<List<CheckUserCredentials>>> CheckUserCredentials(ToCheckUserCredentials toCheckUserCredentials)
        {
            return await userRepository.CheckUserCredentials(toCheckUserCredentials);
        }
        public async Task<ServiceResponseData<List<BlockedSlot>>> BlockedSlot(ToBlockedSlot ToBlockedSlot)
        {
            return await userRepository.BlockedSlot(ToBlockedSlot);
        }
        public async Task<ServiceResponse> SlotDeletion(SlotDeletion slotDeletion)
        {
            return await userRepository.SlotDeletion(slotDeletion);
        }
    }
}
