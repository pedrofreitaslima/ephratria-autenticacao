using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ephratria.Authentication.Application.Commons.Errors;

namespace Ephratria.Authentication.Api.Controllers;

public class ErrorController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

        var (statusCode, message) = exception switch
        {
            IServiceException serviceException =>
            (
                (int)serviceException.StatusCode, serviceException.ErrorMessage
            ),
            _ => (StatusCodes.Status500InternalServerError, "Ocorreu um erro inesperado")
        };

        return Problem(statusCode: statusCode, title: message);
    }
}