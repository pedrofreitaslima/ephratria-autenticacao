using Ephratria.Authentication.Domain.Commons.Models;

namespace Ephratria.Authentication.Domain.UserAggregates.ValueObjects;

public sealed class FirstName : ValueObject
{
    public string Value { get; private set; }

    private FirstName(string value)
    {
        Value = value;
    }

    public static FirstName Create(string value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}