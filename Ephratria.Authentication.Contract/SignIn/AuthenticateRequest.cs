namespace Ephratria.Authentication.Contract.SignIn;

public record AuthenticateRequest(
    byte[] BiometricFile);