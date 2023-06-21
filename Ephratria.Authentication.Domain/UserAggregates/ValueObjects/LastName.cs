using Ephratria.Authentication.Domain.Commons.Models;

namespace Ephratria.Authentication.Domain.UserAggregates.ValueObjects;

public sealed class LastName : ValueObject
{
    public string Value { get; private set; }

    private LastName(string value)
    {
        Value = value;
    }

    public static LastName Create(string value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}