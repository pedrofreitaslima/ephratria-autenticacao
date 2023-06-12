using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
    
    [Route("signup")]
    public IActionResult SignUp()
    {
        return Ok();
    }
    
    [Route("attach")]
    public IActionResult AttachBiometry()
    {
        return Ok();
    }
    
    [Route("signin")]
    public IActionResult SignIn()
    {
        return Ok();
    }
    
    [Route("auth")]
    public IActionResult Authenticate()
    {
        return Ok();
    }
}