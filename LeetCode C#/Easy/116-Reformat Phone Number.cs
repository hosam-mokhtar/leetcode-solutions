Link: https://leetcode.com/problems/reformat-phone-number/
Language: C#





public class Solution {
        public string ReformatNumber(string number)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                    temp.Append(number[i]);
            }
            if (temp.Length > 3)
            {
                return getPhoneNumber(temp);
            }
            return temp.ToString();
        }
        private string getPhoneNumber(StringBuilder sb)
        {
            StringBuilder result = new StringBuilder();
            int counter = 0;
            if (sb.Length % 3 == 1)
            {
                for (int i = 0; i < sb.Length - 2; i++)
                {
                    result.Append(sb[i]);
                    counter++;
                    if (counter == 3)
                    {
                        counter = 0;
                        result.Append('-');
                    }
                    else if (i == sb.Length - 3 && counter == 2)
                    {
                        result.Append('-');
                    }
                }
                result.Append(sb[sb.Length - 2]);
                result.Append(sb[sb.Length - 1]);
            }
            else
            {
                for (int i = 0; i < sb.Length; i++)
                {
                    result.Append(sb[i]);
                    counter++;
                    if (i != sb.Length - 1 && counter == 3)
                    {
                        counter = 0;
                        result.Append('-');
                    }
                }
            }
            return result.ToString();
        }
}