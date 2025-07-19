Link: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
Language: C#








public class Solution {
        public int[] TwoSum(int[] numbers, int target)
        {
            int index1 = 0, index2 = numbers.Length - 1;

            while (index1 < index2)
            {
                if (numbers[index1] + numbers[index2] == target)
                    return [index1 + 1, index2 + 1];
                else if (numbers[index1] + numbers[index2] > target)
                    index2--;
                else
                    index1++;
            }

            return [-1, -1];
        }
}