Link: https://leetcode.com/problems/find-lucky-integer-in-an-array/
Language: C#



public class Solution {
        public int FindLucky(int[] arr)
        {
            int lucky_num = -1;
            int[] n = new int[501];
            for (int i = 0; i < arr.Length; i++)
            {
                n[arr[i]]++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (n[arr[i]] == arr[i] && arr[i] > lucky_num)
                    lucky_num = arr[i];
            }
            return lucky_num;
        }
}