using Dapper;
using instapark.IPmodels;
using instapark.IPRepository.Interfaces;

namespace instapark.IPRepository
{
    public class UserRepository(IDapperSqlProvider dapperSqlProvider) : IUserRepository
    {
        public async Task<ServiceResponseData<List<Users>>> GetUser(GetUser getUser)
        {
            var response = new ServiceResponseData<List<Users>>();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@userName", getUser.userName);
                var dbResponse = await dapperSqlProvider.ExecuteProc<Users>("GetUsers", dynamicParameters);
                response.Status = dbResponse.Status;
                response.Messages = dbResponse.Messages;
                response.Data = dbResponse.Data;
            }
            catch (Exception ex)
            {
            }
            return response;
        }
        public async Task<ServiceResponse> SignUp(SignUp signUp)
        {
            var response = new ServiceResponse();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@userName", signUp.userName);
                dynamicParameters.Add("@phoneNumber", signUp.phoneNumber);
                dynamicParameters.Add("@email", signUp.email);
                dynamicParameters.Add("@password", signUp.password);
                var dbResponse = await dapperSqlProvider.ExecuteProc<int>("GetUsers", dynamicParameters);
                response.Status = dbResponse.Status;
                response.Messages = dbResponse.Messages;
            }
            catch(Exception ex) { }
            return response;
        }
        public async Task<ServiceResponse> BookingDetails(BookingDetails bookingDetails)
        {
            var response = new ServiceResponse();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@selectedSlots", bookingDetails.selectedSlot);
                dynamicParameters.Add("@userName", bookingDetails.userName);
                dynamicParameters.Add("@phoneNumber", bookingDetails.phoneNumber);
                dynamicParameters.Add("@numberPlate", bookingDetails.numberPlate);
                var dbrespose = await dapperSqlProvider.ExecuteProc<int>("GetBookingDetails", dynamicParameters);
                response.Status = dbrespose.Status;
                response.Messages = dbrespose.Messages;
            }
            catch(Exception ex) { }
            return response;
        }

    }

}
