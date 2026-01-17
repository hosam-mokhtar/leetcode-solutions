Link: https://leetcode.com/problems/distribute-candies-to-people/
Language: C#







public class Solution {
        public int[] DistributeCandies(int candies, int num_people)
        {
            int[] res = new int[num_people];
            int c = 1;

            while (candies > 0)
            {
                for (int i = 0; i < num_people; i++)
                {
                    res[i] += c;
                    candies-=c;

                    if(c >= candies)
                       c = candies;
                    else if (candies == 0)
                       break;
                    else   
                       c++;
                }
            }

            return res;
        }
}