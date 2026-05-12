Link: https://leetcode.com/problems/check-if-array-is-sorted-and-rotated/
Language: C#







public class Solution
{
    public bool Check(int[] nums)
    {
        if (nums.Length == 1) return true;

        int[] temp = new int[nums.Length * 2];

        for (int i = 0; i < nums.Length; i++)
        {
            temp[i] = nums[i];
            temp[nums.Length + i] = nums[i];
        }

        int c = 1;
        int maxLen = 1;

        for (int i = 1; i < temp.Length; i++)
        {
            if (temp[i - 1] <= temp[i])
            {
                c++;
                maxLen = Math.Max(maxLen, c);

                if (maxLen == nums.Length)
                    return true;
            }
            else
                c = 1;
        }

        return false;
    }
}