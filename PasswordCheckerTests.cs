using Xunit;
using PasswordStrength;

namespace PasswordStrngthTest

{
    public class PasswordCheckerTests
    {
        [Fact]
        public void TestEmptyPassword()
        {
            Assert.Equal("Ineligable", PasswordChecker.CheckStrength(""));
        }
        [Fact]

        public void TestWeakPassword()
        {
            Assert.Equal("Weak", PasswordChecker.CheckStrength("abcdef"));
            Assert.Equal("Weak", PasswordChecker.CheckStrength("ABCDEF"));
            Assert.Equal("Weak", PasswordChecker.CheckStrength("123456"));
            Assert.Equal("Weak", PasswordChecker.CheckStrength("!!!!!!"));
        }

        [Fact]
        public void TestMediumPassword()
        {
            Assert.Equal("Medium", PasswordChecker.CheckStrength("abcDEF"));
            Assert.Equal("Medium", PasswordChecker.CheckStrength("abc123"));
            Assert.Equal("Medium", PasswordChecker.CheckStrength("ABC123"));
            Assert.Equal("Medium", PasswordChecker.CheckStrength("abc!@#"));
            Assert.Equal("Medium", PasswordChecker.CheckStrength("ABC!@#"));
            Assert.Equal("Medium", PasswordChecker.CheckStrength("123!@#"));
        }

        [Fact]
        public void TestStrongPassword()
        {
            Assert.Equal("Strong", PasswordChecker.CheckStrength("Abc123!@#"));
            Assert.Equal("Strong", PasswordChecker.CheckStrength("A1b2C3!@#"));
            Assert.Equal("Strong", PasswordChecker.CheckStrength("!@#Abc123"));
        }


    }
}