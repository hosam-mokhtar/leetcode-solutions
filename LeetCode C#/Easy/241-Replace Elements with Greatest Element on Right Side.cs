Link: https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/
Language: C#








public class Solution {
        public int[] ReplaceElements(int[] arr)
        {
            int max = arr[^1];
            arr[^1] = -1;
            
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                int num = arr[i];
                arr[i] = max;

                if (num > max)
                    max = num;
            }

            return arr;
        }
}