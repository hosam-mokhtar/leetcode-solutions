Link: https://leetcode.com/problems/password-strength/
Language: C#









public class Solution {
        public int PasswordStrength(string password)
        {
            int c = 0;
            int[] freq = new int[123]; //ascii table

            for (int i = 0; i < password.Length; i++)
            {
                freq[password[i]]++;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (freq[password[i]] == 0)
                    continue;

                if (password[i] >= 'a' && password[i] <= 'z')
                    c++;
                else if (password[i] >= 'A' && password[i] <= 'Z')
                    c += 2;
                else if (password[i] >= '0' && password[i] <= '9')
                    c += 3;
                else
                    c += 5;

                freq[password[i]] = 0;
            }

            return c;
        }
}