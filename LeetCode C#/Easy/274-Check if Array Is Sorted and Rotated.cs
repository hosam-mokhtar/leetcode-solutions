Link: https://leetcode.com/problems/check-if-array-is-sorted-and-rotated/
Language: C#







public class Solution
{
    public bool Check(int[] nums)
    {
        int count = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] > nums[i])
            {
                count++;
                if (count > 1)
                    return false;
            }
        }

        if (count == 1 && nums[nums.Length - 1] > nums[0])
            return false;
        return true;
    }
}