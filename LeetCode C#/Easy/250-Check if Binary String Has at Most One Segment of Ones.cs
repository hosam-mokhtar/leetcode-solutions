Link: https://leetcode.com/problems/check-if-binary-string-has-at-most-one-segment-of-ones/
Language: C#







public class Solution {
    public bool CheckOnesSegment(string s)
    {
        return !s.Contains("01");
    }
}