namespace PasswordStrength
{
    public class PasswordChecker
    {
        public static string CheckStrength(string password)
        {
            if (password == null || password == ""){
                return "Ineligable";
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