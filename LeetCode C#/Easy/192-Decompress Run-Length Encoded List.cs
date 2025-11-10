Link: https://leetcode.com/problems/decompress-run-length-encoded-list/
Language: C#






public class Solution {
        public int[] DecompressRLElist(int[] nums)
        {
            var list = new List<int>();

            for (int i = 0; i < nums.Length; i += 2)
            {
                int c = nums[i];
                
                while (c > 0)
                {
                    list.Add(nums[i + 1]);
                    c--;
                }
            }

            return list.ToArray();
        }
}