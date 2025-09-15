/// <summary>
/// Generates a version 4 UUID (randomly generated).
/// </summary>
/// <returns>
/// A string representing a valid version 4 UUID in standard format,
/// for example: "f47ac10b-58cc-4372-a567-0e02b2c3d479".
/// </returns>


using Xunit;
using PasswordStrength;

namespace UUIDtest;

public class UuidTests

{
    [Fact]
    public void TestGenerateUUIDv4()
    {
        string uuid = Uuid.GenerateUUIDv4();


        Assert.True(System.Guid.TryParse(uuid, out var parsedGuid));


        Assert.Equal('4', uuid[14]);
    }
 }
