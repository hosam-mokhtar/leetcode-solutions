Link: https://leetcode.com/problems/sum-of-all-odd-length-subarrays/
Language: C#





public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int totalSum = 0;
        for (int i = 0; i < arr.Length; i++) {
            int sum = (i + 1) * (arr.Length - i);
            int odd = (sum + 1) / 2;
            totalSum += arr[i] * odd;
        }
        return totalSum;
    }
}