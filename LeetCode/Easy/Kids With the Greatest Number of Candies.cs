Link: https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
Language: C#


public class Solution {
public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = 0;
            List<bool> result = new List<bool>();
            for (int i = 0; i < candies.Length; i++)
            {
                if (max < candies[i])
                {
                    max = candies[i];
                }
            }
            for(int i=0; i<candies.Length; i++)
            {
               result.Add(max <= candies[i] + extraCandies);
            }
            return result;
        }
}