using Ephratria.Authentication.Domain.Commons.Models;

namespace Ephratria.Authentication.Domain.UserAggregates.ValueObjects;

public sealed class BiometryId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    private BiometryId(Guid value)
    {
        Value = value;
    }

    public static BiometryId Create(Guid id)
    {
        return new BiometryId(id);
    }

    public static BiometryId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}