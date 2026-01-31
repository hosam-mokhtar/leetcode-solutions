Link: https://leetcode.com/problems/snake-in-matrix/
Language: C#







public class Solution {
        public int FinalPositionOfSnake(int n, IList<string> commands)
        {
            int index = 0;
            foreach (string i in commands)
            {
                switch(i)
                {
                case "RIGHT":
                    index++;
                    break;
                case "LEFT":
                    index--;
                    break;
                case "UP":
                    index -= n;
                    break;
                case "DOWN":
                    index += n;
                    break;
                }
            }
            return index;
        }
