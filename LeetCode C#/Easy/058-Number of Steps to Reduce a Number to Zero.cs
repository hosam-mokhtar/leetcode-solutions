Link: https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
Language: C#






public class Solution {
        public int NumberOfSteps(int num)
        {   if(num == 0) return 0;
            int steps = 0;
            while (num > 0) {            
                if(num % 2 == 0)
                    num /=2;
                else
                    num -= 1;
            steps++;
            }
            return steps;
        }
}