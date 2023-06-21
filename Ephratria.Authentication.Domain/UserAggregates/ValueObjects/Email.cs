using Ephratria.Authentication.Domain.Commons.Models;

namespace Ephratria.Authentication.Domain.UserAggregates.ValueObjects;

public sealed class Email : ValueObject
{
    public string Value { get; private set; }

    private Email(string value)
    {
        Value = value;
    }

    public static Email Create(string value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}