using instapark.IPmodels;
using Dapper;

namespace instapark.IPRepository.Interfaces
{
    public interface IDapperSqlProvider
    {
        Task<ServiceResponseData<List<T>>> ExecuteProc<T>(string procName, DynamicParameters procParams);
    }
}