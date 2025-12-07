Link: https://leetcode.com/problems/find-the-original-array-of-prefix-xor/
Language: C#






public class Solution {
        public int[] FindArray(int[] pref)
        {
            int left = pref[0];

            for (int i = 1; i < pref.Length; i++)
            {
                int temp = pref[i];
                pref[i] = left ^ pref[i];
                left = temp;
            }

            return pref;
        }
}