Link: https://leetcode.com/problems/strong-password-checker-ii/
Language: C#





public class Solution {
        public bool StrongPasswordCheckerII(string password)
        {
            if (password.Length < 8) return false;

            string specialChars = "!@#$%^&*()-+";
            bool special = false;
            bool digit = false;
            bool upper = false;
            bool lower = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (i > 0 && password[i] == password[i - 1])
                    return false;
                if (char.IsDigit(password[i]))
                    digit = true;
                else if (char.IsUpper(password[i]))
                    upper = true;
                else if (char.IsLower(password[i]))
                    lower = true;
                else if (specialChars.Contains(password[i]))
                    special = true;
            }

            return special && digit && upper && lower;
        }
}