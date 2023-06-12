using System.Net;

namespace Ephratria.Authentication.Application.Commons.Errors;

public interface IServiceException
{
    public HttpStatusCode StatusCode => throw new NotImplementedException();
    public string ErrorMessage => throw new NotImplementedException();
}