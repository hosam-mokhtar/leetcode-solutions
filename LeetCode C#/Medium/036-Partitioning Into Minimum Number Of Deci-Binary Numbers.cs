Link: https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/
Language: C#






public class Solution {
        public int MinPartitions(string n)
        {
            int maxLen = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == 9)
                    return 9;
                if (n[i] - '0' > maxLen)
                    maxLen = n[i] - '0';
            }

            return maxLen;
        }
}