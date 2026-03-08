Link: https://leetcode.com/problems/find-unique-binary-string/
Language: C#






public class Solution {
    public string FindDifferentBinaryString(string[] nums)
    {
        int n = nums.Length;
        char[] res = new char[n];

        for (int i = 0; i < n; i++)
        {
            res[i] = nums[i][i] == '1' ? '0' : '1';
        }

        return new string(res);
    }
}