Link: https://leetcode.com/problems/shortest-distance-to-target-string-in-a-circular-array/
Language: C#








public class Solution {
        public int ClosestTarget(string[] words, string target, int startIndex)
        {
            int closest = int.MaxValue;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == target)
                {
                    closest = Math.Min(closest, Math.Abs(i - startIndex));
                    if (startIndex > i)
                        closest = Math.Min(closest, Math.Abs(words.Length - startIndex + i));
                    else
                        closest = Math.Min(closest, Math.Abs(words.Length - i + startIndex));
                }
            }

            return closest == int.MaxValue ? -1 : closest;
        }
}