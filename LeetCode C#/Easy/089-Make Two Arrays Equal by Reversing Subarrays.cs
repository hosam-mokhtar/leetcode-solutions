Link: https://leetcode.com/problems/make-two-arrays-equal-by-reversing-subarrays/
Language: C#






public class Solution {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            int[] freq = new int[1001];
            for (int i = 0; i < arr.Length; i++)
            {
                freq[arr[i]]++;
                freq[target[i]]--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if(freq[arr[i]]!=0)  return false;
            }
            return true;
        }
}