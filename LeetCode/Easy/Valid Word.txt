Link: https://leetcode.com/problems/valid-word/
Language: C#



public class Solution {
public bool IsValid(string word)
        {
            bool vowel_char = false;
            bool constant_char = false;
            bool number = false;
            bool upper = false;
            bool lower = false;
            for (int i=0;i<word.Length;i++)
            {
                if(!char.IsLetterOrDigit(word[i]))
                    return false;
                if (char.IsUpper(word[i]))
                    upper = true;
                if (char.IsLower(word[i]))
                    lower = true;
                if("aeiouAEIOU".IndexOf(word[i])>-1)
                    vowel_char = true;
                else if (word[i] >= 'a' && word[i]<='z'|| word[i] >= 'A' && word[i] <= 'Z')
                    constant_char = true;
                else if(word[i] >= '0' && word[i] <= '9')
                    number = true;
            }
            if(vowel_char&&constant_char&&number&&upper&&lower||constant_char&&vowel_char&&word.Length>=3)
                 return true;
            return false;
        }
}