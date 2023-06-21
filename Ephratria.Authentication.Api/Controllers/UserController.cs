using Ephratria.Authentication.Application.Commands;
using Ephratria.Authentication.Application.Queries;
using Ephratria.Authentication.Application.Results;
using Ephratria.Authentication.Contract.SignIn;
using Ephratria.Authentication.Contract.SignUp;
using Ephratria.Authentication.Domain.Commons.Errors;
using MapsterMapper;
using MediatR;
using ErrorOr;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SignInResult = Ephratria.Authentication.Application.Results.SignInResult;

namespace Ephratria.Authentication.Api.Controllers;

[Route("/v1")]
[AllowAnonymous]
public class UserController : EphratriaBaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public UserController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
    
    #region Sign Up Context
    [Route("signup")]
    public async Task<IActionResult> SignUp(SignUpRequest request)
    {
        var command = _mapper.Map<SignUpCommand>(request);
        ErrorOr<SignUpResult> result = await _mediator.Send(command);
        
        return result.Match(
            success => Ok(_mapper.Map<SignUpResponse>(success)),
            errors => Problem(errors)
        );
    }

    [HttpGet("validate-nickname")]
    public async Task<IActionResult> ValidateNickname(object request)
    {
        await Task.CompletedTask;
        
        // crete query
        // get result
        // info response
        
        return default;
    }
    
    [HttpGet("validate-email")]
    public async Task<IActionResult> ValidateEmail(object request)
    {
        await Task.CompletedTask;
        
        // crete query
        // get result
        // info response
        
        return default;
    }
    
    
    [Route("attach-biometry")]
    public async Task<IActionResult> AttachBiometry(AttachRequest request)
    {
        var command = _mapper.Map<AttachCommand>(request);
        ErrorOr<AttachResult> result = await _mediator.Send(command);
        
        return result.Match(
            success => Ok(_mapper.Map<AttachResponse>(success)),
            errors => Problem(errors)
        );
    }
    
    #endregion
    
    [Route("signin")]
    public async Task<IActionResult> SignIn(SignInRequest request)
    {
        var query = _mapper.Map<SignInQuery>(request);
        ErrorOr<SignInResult> result = await _mediator.Send(query);
        
        if (result.IsError && result.FirstError == Errors.SignIn.InvalidNickname)
        {
            return Problem(statusCode: StatusCodes.Status401Unauthorized, 
                title: result.FirstError.Description);
        }
        return result.Match(
            success => Ok(_mapper.Map<SignInResponse>(success)),
            errors => Problem(errors)
        );
    }
    
    [Route("auth-biometric")]
    public async Task<IActionResult> Authenticate(AuthenticateRequest request)
    {
        var query = _mapper.Map<AuthenticateQuery>(request);
        ErrorOr<AuthenticateResult> result = await _mediator.Send(query);
        
        if (result.IsError && result.FirstError == Errors.Authenticate.InvalidBiometrics)
        {
            return Problem(statusCode: StatusCodes.Status401Unauthorized, 
                title: result.FirstError.Description);
        }
        return result.Match(
            success => Ok(_mapper.Map<AuthenticateResponse>(success)),
            errors => Problem(errors)
        );
    }
}