Link: https://leetcode.com/problems/mean-of-array-after-removing-some-elements/
Language: C#







public class Solution {
        public double TrimMean(int[] arr)
        {
            Array.Sort(arr);

            double sum = 0;
            int len = arr.Length * 5 / 100;

            for (int i = len; i < arr.Length - len; i++)
            {
                sum += arr[i];
            }

            return sum / (arr.Length - (len * 2));
        }
}