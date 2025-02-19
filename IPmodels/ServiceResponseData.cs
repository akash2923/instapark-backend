
namespace instapark.IPmodels;

public class ServiceResponseData<T> : ServiceResponse
{
    public T Data { get; set; }
}