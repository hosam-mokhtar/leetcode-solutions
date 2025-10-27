Link: https://leetcode.com/problems/check-if-word-equals-summation-of-two-words/
Language: C#







public class Solution {
        public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            int x = 0, y = 0, z = 0;
            int len = Math.Max(firstWord.Length, 
                      Math.Max(secondWord.Length, targetWord.Length));

            for (int i = 0; i < len; i++)
            {
                if (firstWord.Length > i)
                {
                    x *= 10;
                    x += firstWord[i] - 'a';
                }
                if (secondWord.Length > i)
                {
                    y *= 10;
                    y += secondWord[i] - 'a';
                }
                if (targetWord.Length > i)
                {
                    z *= 10;
                    z += targetWord[i] - 'a';
                }
            }

            return x + y == z;
        }
}