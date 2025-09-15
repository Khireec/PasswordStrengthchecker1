/// <summary>
/// Checks the strength of a password using several criteria:
/// - Minimum length of 8 characters (if shorter, returns "INELIGIBLE").
/// - At least one uppercase letter.
/// - At least one lowercase letter.
/// - At least one digit.
/// - At least one symbol.
///
/// The method reads the password character-by-character, increases count in increments of 1 for each
/// criteria met, counts how many criteria are met, and returns the following depending
/// on how many in:
/// - 0 criteria met = "INELIGIBLE"
/// - 1 criteria met = "WEAK"
/// - 2 or 3 criteria met = "MEDIUM"
/// - 4 criteria met = "STRONG"
/// - If password is empty or has less than 8, returns:
///   - "Insufficient Password Length. Must Have 8 Character"
/// </summary>

namespace PasswordStrength
{
    public class PasswordChecker
    {
        public static string CheckStrength(string password)
        {
            if (password.Length >=1 && password.Length <8)
            {
                return "Insufficient Password Length. Must Have 8 Character";
            }


            if (password == null || password == ""){
                return "Ineligible";
            }
            bool isUpperCase = false;
            bool isLowerCase = false;
            bool hasNum = false;
            bool hasSymbol = false;

            foreach (char c in password) {
                if (c >= 'A' && c <= 'Z')
                {
                    isUpperCase = true;
                }

                else if (c >= 'a' && c <= 'z')
                {
                    isLowerCase = true;
                }
                else if (c >= '0' && c <= '9')
                {
                    hasNum = true;
                }
                else
                {
                    hasSymbol = true;
                }

            }

            int criteriaMet = 0;
            if (isUpperCase) criteriaMet++;
            if (isLowerCase) criteriaMet++;
            if (hasNum) criteriaMet++;
            if (hasSymbol) criteriaMet++;

            if (criteriaMet == 0)
                {
                return "Ineligable";
            }
            else if (criteriaMet == 1)
            {
                return "Weak";
            }
            else if (criteriaMet == 2 || criteriaMet == 3)
            {
                return "Medium";
            }
            else
            {
                return "Strong";
            }
        }
    }
    
}