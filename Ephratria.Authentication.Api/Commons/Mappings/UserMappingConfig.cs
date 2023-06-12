using Ephratria.Authentication.Application.Commands;
using Ephratria.Authentication.Application.Queries;
using Ephratria.Authentication.Application.Results;
using Ephratria.Authentication.Contract.SignIn;
using Ephratria.Authentication.Contract.SignUp;
using Mapster;

namespace Ephratria.Authentication.Api.Commons.Mappings;

public class UserMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<AttachRequest, AttachCommand>();
        config.NewConfig<AttachResult, AttachResponse>();
        
        config.NewConfig<AuthenticateRequest, AuthenticateQuery>();
        config.NewConfig<AuthenticateResult, AuthenticateResponse>();
        
        config.NewConfig<SignInRequest, SignInQuery>();
        config.NewConfig<SignInResult, SignInResponse>();
        
        config.NewConfig<SignUpRequest, SignUpCommand>();
        config.NewConfig<SignUpResult, SignUpResponse>();
    }
}