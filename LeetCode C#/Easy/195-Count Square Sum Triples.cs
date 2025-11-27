Link: https://leetcode.com/problems/count-square-sum-triples/
Language: C#






public class Solution {
        public int CountTriples(int n)
        {
            int counter = 0;

            for (int i = n; i >= 5; i--)
            {
                for (int j = i - 1; j >= 3; j--)
                {
                    int a = j * j;
                    int c = i * i;
                    int b = c - a;
                    int sqrtB = (int)Math.Sqrt(b);

                    if (sqrtB * sqrtB == b)
                        counter++;
                }
            }

            return counter;
        }
}