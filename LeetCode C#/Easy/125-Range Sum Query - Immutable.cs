Link: https://leetcode.com/problems/range-sum-query-immutable/
Language: C#






        public class NumArray
        {
            public int[] nums;

            public NumArray(int[] nums)
            {
                this.nums = nums;
                prefixSum();
            }
            
            public void prefixSum()
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    nums[i] += nums[i - 1];
                }
            }

            public int SumRange(int left, int right)
            {
                if (left > 0)
                    return nums[right] - nums[left - 1];
                else
                    return nums[right];
            }
        }

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */