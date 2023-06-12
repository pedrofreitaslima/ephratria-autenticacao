# Ephratria
# Authenctication API
## Description
This project is a micro services that compose the EPhratria ecommerce, and this object is sign up and sign in users in the application, then you can register a new user and sign in the appplication after using credentials that compose the nickname and user biometrics.

## How to use
### - Routes
The routes to contains in this API are describe bellow:

#### - Sign Up
If you want to sign up a new user use this route

```http
POST {{host}}/v1/signup/
Content-Type: application/json
```

```json
{
  "firstName": "Pedro",
  "lastName": "Lima",
  "email": "contact@pedrofreitaslma.com",
  "nickName": "pedrofreitaslima"
}
```

#### - Sign In
If you want to sign in, first enter with nickname

```http
POST {{host}}/v1/signin/{nickname}
Content-Type: application/json
```

```json
{
  "nickName": "pedrofreitaslima"
}
```

#### - Attach Biometric
If you want to attach your face biometric, create a new user  nickname before and after attach your face biometric in this user account

```http
POST {{host}}/v1/attach/{nickname}
Content-Type: application/json
```

```json
{
  "biometricFile": "asdfsafas16131a6f5a46s1sa31asf6as41a16c13fas64as"
}
```

#### - Authenticate Biometric
If you want to sign in, after nickname validate then enter with your face biometric


```http
POST {{host}}/v1/auth/{nickname}
Content-Type: application/json
```

```json
{
  "biometricFile": "asdfsafas16131a6f5a46s1sa31asf6as41a16c13fas64as"
}


## Technologies
- .NET 7.0
- C# 12.0
- Docker
- Kubernetes
- AWS
- API
- API Gateway
- Load Balance
- AWS S3
- AWS RDS

## Patterns
- Object-Oriented Programming
- Clean Architecture
- Clean Code
- Domain Driven Design (DDD)
- Test Driven Development (TDD)
- Unit Test
- Integration Test
- Don't repeat youself (DRY)
- Keep it Simple, Stupid (KISS)
- SOLID
- You aren't gonna neded it (YAGNI)
- Dependency Injection (DI)


## Tools
- JetBrains Rider
- Visual Studio Code
- Insominia

## Dependencies
- XUnit
- Mapster
- ErrorOr
- FluentValidators
- FluentAssertions
- Moq
- MediatR
- Microsoft.AspNetCore.Authentication.JwtBearer
- Microsoft.IdentityModel

## Authors
&copy; EPhratria &copy;
#### Integrants:
- Bruno Fabiani Alves Peres
- Lucas Santos do Nascimento
- Maísa Serpa Castro Moreira
- Pedro Henrique Alexandre Freitas de Lima
- Rafael Lee Avalo de Melo Gaia
