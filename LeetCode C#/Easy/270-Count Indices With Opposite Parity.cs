Link: https://leetcode.com/problems/count-indices-with-opposite-parity/
Language: C#







public class Solution
{
    public int[] CountOppositeParity(int[] nums)
    {
        int totalEven = 0;
        int totalOdd = 0;
        int evenSeenSoFar = 0;
        int oddSeenSoFar = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
                totalEven++;
            else
                totalOdd++;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                nums[i] = totalOdd - oddSeenSoFar;
                evenSeenSoFar++;
            }
            else
            {
                nums[i] = totalEven - evenSeenSoFar;
                oddSeenSoFar++;
            }
        }

        return nums;
    }
}