Link: https://leetcode.com/problems/alternating-digit-sum/
Language: C#




public class Solution {
public int AlternateDigitSum(int n) {
    string s = n.ToString();
    int result = 0;
    for (int i = s.Length-1; i >=0 ; i--)
    {
        if (i % 2 == 0)
            result += s[i]-'0';
        else
            result -= s[i]-'0';
    }
    return result;
}
}