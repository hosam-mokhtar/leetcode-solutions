Link: https://leetcode.com/problems/detect-capital/
Language: C#





public class Solution {
        public bool DetectCapitalUse(string word) {
            int capital = 0, small = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'a' && word[i] <= 'z')
                    small++;
                else if (word[i] >= 'A' && word[i] <= 'Z')
                    capital++;
                else if(capital>1 && small>0)
                    return false;    
            }
            return small == word.Length || capital == word.Length ||
                (capital == 1 && word[0] >= 'A' && word[0]<='Z') ?true:false;
        }
}