using Ephratria.Authentication.Domain.Commons.Models;
using Ephratria.Authentication.Domain.UserAggregates.ValueObjects;

namespace Ephratria.Authentication.Domain.UserAggregates.Entities;

public class Biometry : Entity<BiometryId>
{
    public string FilePath { get; private set; }
    public string FileName { get; private set; }
    public byte[] File { get; private set; }
    public DateTime CreatedDateTime { get; private set; }
    public DateTime UpdatedDateTime { get; private set; } 
    
    private Biometry(){}
    
    private Biometry(BiometryId biometryId, string filePath, string fileName)
        : base(biometryId)
    {
        FilePath = filePath;
        FileName = fileName;
        CreatedDateTime = DateTime.Now;
        UpdatedDateTime = DateTime.Now;
    }

    private Biometry(BiometryId biometryId, string filePath, string fileName, byte[] file)
        : this(biometryId, filePath, fileName)
    {
        File = file;
    }

    public static Biometry Create(
        string filePath,
        string fileName)
    {
        return new(
            BiometryId.CreateUnique(),
            filePath,
            fileName);
    }
    
    public static Biometry Create(
        string filePath,
        string fileName,
        byte[] file)
    {
        return new(
            BiometryId.CreateUnique(),
            filePath,
            fileName,
            file);
    }
}