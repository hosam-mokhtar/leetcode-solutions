Link: https://leetcode.com/problems/largest-odd-number-in-string/
Language: C#








public class Solution {
        public string LargestOddNumber(string num)
        {
            var index = num.LastIndexOfAny(['1', '3', '5', '7', '9']);

            return index < 0 ? string.Empty : num.Substring(0, ++index);
        }
}