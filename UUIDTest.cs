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
