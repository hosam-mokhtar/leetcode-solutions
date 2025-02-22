Link: https://leetcode.com/problems/convert-a-number-to-hexadecimal/
Language: C#


public class Solution {
public string ToHex(int num)
        {
            string s = Convert.ToString(num, 16);
            return s;
        }
}