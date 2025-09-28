Link: https://leetcode.com/problems/compute-decimal-representation/
Language: C#






public class Solution {
        public int[] DecimalRepresentation(int n)
        {
            var list = new List<int>();
            int c = 1;

            while (n > 0)
            {
                int i = n % 10;

                if (i != 0)
                    list.Add(i * c);

                c *= 10;
                n /= 10;
            }

            list.Reverse();

            return list.ToArray();
        }
}