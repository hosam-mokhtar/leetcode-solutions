Link: https://leetcode.com/problems/count-the-number-of-special-characters-i/
Language: C#







public class Solution {
        public int NumberOfSpecialChars(string word)
        {
            bool[] smalls = new bool[26];
            bool[] capitals = new bool[26];

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] <= 'Z')
                    capitals[word[i] - 'A'] = true;
                else
                    smalls[word[i] - 'a'] = true;
            }

            int counter = 0;

            for (int i = 0; i < 26; i++)
            {
                if (capitals[i] == true && smalls[i] == true)
                    counter++;
            }

            return counter;
        }
}