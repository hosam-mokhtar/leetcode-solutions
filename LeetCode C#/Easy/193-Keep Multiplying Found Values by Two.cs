Link: https://leetcode.com/problems/keep-multiplying-found-values-by-two/
Language: C#





public class Solution {
        public int FindFinalValue(int[] nums, int original)
        {
            while (true)
            {
                if (!nums.Contains(original)) 
                    break;
                original *= 2;
            }

            return original;
        }
}