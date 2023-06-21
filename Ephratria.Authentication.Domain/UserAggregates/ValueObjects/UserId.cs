using Ephratria.Authentication.Domain.Commons.Models;

namespace Ephratria.Authentication.Domain.UserAggregates.ValueObjects;

public sealed class UserId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    private UserId(Guid value)
    {
        Value = value;
    }

    public static UserId Create(Guid id)
    {
        return new UserId(id);
    }

    public static UserId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}