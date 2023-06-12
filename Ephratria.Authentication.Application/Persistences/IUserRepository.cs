using Ephratria.Authentication.Domain.UserAggregates;

namespace Ephratria.Authentication.Application.Persistences;

public interface IUserRepository
{
    User? GetUserByNickname(string email);
    void Add(User user);
}