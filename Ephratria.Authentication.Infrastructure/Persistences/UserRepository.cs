using Ephratria.Authentication.Application.Persistences;
using Ephratria.Authentication.Domain.UserAggregates;

namespace Ephratria.Authentication.Infrastructure.Persistences;

public class UserRepository : IUserRepository
{
    private static readonly IList<User> _users = new List<User>();
    
    public User? GetUserByNickname(string nickname)
    {
        return _users.SingleOrDefault(user => user.Email.Equals(nickname));
    }

    public void Add(User user)
    {
        _users.Add(user);
    }
}