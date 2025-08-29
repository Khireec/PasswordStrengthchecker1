using PasswordStrength;
using Xunit;


namespace PasswordStrngthTest

{
    public class PasswordCheckerTests
    {
        [Fact]
        public void TestEmptyPassword()
        {
            Assert.Equal("Ineligible", PasswordChecker.CheckStrength(""));
        }
        [Fact]

        public void TestSufficientButWeakPassword()
        {
            Assert.Equal("Weak", PasswordChecker.CheckStrength("abcdefgh"));
            Assert.Equal("Weak", PasswordChecker.CheckStrength("ABCDEFGH"));
            Assert.Equal("Weak", PasswordChecker.CheckStrength("12345678"));
            Assert.Equal("Weak", PasswordChecker.CheckStrength("!!!!!!!!"));
        }

        [Fact]
        public void TestSufficientButMediumPassword()
        {
            Assert.Equal("Medium", PasswordChecker.CheckStrength("abcDEFGH"));
            Assert.Equal("Medium", PasswordChecker.CheckStrength("abc12345"));
            Assert.Equal("Medium", PasswordChecker.CheckStrength("ABC12345"));
            Assert.Equal("Medium", PasswordChecker.CheckStrength("abc!@#*&"));
            Assert.Equal("Medium", PasswordChecker.CheckStrength("ABC!@#*&"));
            Assert.Equal("Medium", PasswordChecker.CheckStrength("123!@#*&"));
        }

        [Fact]
        public void TestSufficientStrongPassword()
        {
            Assert.Equal("Strong", PasswordChecker.CheckStrength("Abc123!@#"));
            Assert.Equal("Strong", PasswordChecker.CheckStrength("A1b2C3!@#"));
            Assert.Equal("Strong", PasswordChecker.CheckStrength("!@#Abc123"));
            Assert.Equal("Strong", PasswordChecker.CheckStrength("Password1!"));
            Assert.Equal("Strong", PasswordChecker.CheckStrength("Abcd123!"));
        }

        [Fact]
        public void TestInsufficientLength()
        {
            Assert.Equal("Insufficient Password Length. Must Have 8 Character", PasswordChecker.CheckStrength("Ab1!"));
            Assert.Equal("Insufficient Password Length. Must Have 8 Character", PasswordChecker.CheckStrength("aB3$"));
            Assert.Equal("Insufficient Password Length. Must Have 8 Character", PasswordChecker.CheckStrength("P10TEN"));
            Assert.Equal("Insufficient Password Length. Must Have 8 Character", PasswordChecker.CheckStrength("PWORD89"));
        }
        
        
    }
}