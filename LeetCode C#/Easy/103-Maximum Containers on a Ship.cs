Link: https://leetcode.com/problems/maximum-containers-on-a-ship/
Language: C#





public class Solution {
        public int MaxContainers(int n, int w, int maxWeight)
        {
            return Math.Min(n * n, maxWeight / w);
        }
}