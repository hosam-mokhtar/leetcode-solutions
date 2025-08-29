Link: https://leetcode.com/problems/di-string-match/
Language: C#






public class Solution {
        public int[] DiStringMatch(string s)
        {
            var arr = new int[s.Length + 1];
            int left = 0;
            int right = s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                    arr[i] = left++;
                else
                    arr[i] = right--;
            }

            arr[s.Length] = left;
            
            return arr;
        }
}