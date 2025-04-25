Link: https://leetcode.com/problems/integer-to-roman/
Language: C#






public class Solution {
        public string IntToRoman(int num)
        {
            List<char> result = [];
            while (num > 0)
            {
                if (num >= 1000)
                {
                    result.Add('M');
                    num -= 1000;
                }
                else if (num >= 900)
                {
                    result.Add('C');
                    result.Add('M');
                    num -= 900;
                }
                else if (num >= 500)
                {
                    result.Add('D');
                    num -= 500;
                }
                else if (num >= 400)
                {
                    result.Add('C');
                    result.Add('D');
                    num -= 400;
                }
                else if (num >= 100)
                {
                    result.Add('C');
                    num -= 100;
                }
                else if (num >= 90)
                {
                    result.Add('X');
                    result.Add('C');
                    num -= 90;
                }
                else if (num >= 50)
                {
                    result.Add('L');
                    num -= 50;
                }
                else if (num >= 40)
                {
                    result.Add('X');
                    result.Add('L');
                    num -= 40;
                }
                else if (num >= 10)
                {
                    result.Add('X');
                    num -= 10;
                }
                else if (num >= 9)
                {
                    result.Add('I');
                    result.Add('X');
                    num -= 9;
                }
                else if (num >= 5)
                {
                    result.Add('V');
                    num -= 5;
                }
                else if (num >= 4)
                {
                    result.Add('I');
                    result.Add('V');
                    num -= 4;
                }
                else if (num >= 1)
                {
                    result.Add('I');
                    num -= 1;
                }
            }
            return new string(result.ToArray());
        }
}