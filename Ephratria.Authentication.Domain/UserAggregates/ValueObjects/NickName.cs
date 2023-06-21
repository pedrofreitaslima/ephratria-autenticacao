using Ephratria.Authentication.Domain.Commons.Models;

namespace Ephratria.Authentication.Domain.UserAggregates.ValueObjects;

public sealed class NickName : ValueObject
{
    public string Value { get; private set; }

    private NickName(string value)
    {
        Value = value;
    }

    /// <summary>
    /// Method to create a new nickname for user
    /// </summary>
    /// <param name="value">This is the nickname</param>
    /// <returns>Nickname Value Object</returns>
    public static NickName Create(string value)
    {
        return new(value);
    }
    
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}