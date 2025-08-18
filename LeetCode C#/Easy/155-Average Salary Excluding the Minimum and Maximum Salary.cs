Link: https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/
Language: C#






public class Solution {
        public double Average(int[] salary)
        {
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < salary.Length; i++)
            {
                sum += salary[i];

                if (salary[i] > max)
                    max = salary[i];
                if (salary[i] < min)
                    min = salary[i];

            }

            return (sum - (max + min)) * 1.00 / (salary.Length - 2);
        }
}