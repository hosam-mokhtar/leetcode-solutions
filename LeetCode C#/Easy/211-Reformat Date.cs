Link: https://leetcode.com/problems/reformat-date/
Language: C#







public class Solution {
        public string ReformatDate(string date)
        {
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            string result = "";
            int countD, indexM, indexY;
            
            if (char.IsDigit(date[1]))
            {
                countD = 2;
                indexM = 5;
                indexY = 9;
            }
            else
            {
                countD = 1;
                indexM = 4;
                indexY = 8;
            }

            result = date.Substring(indexY, 4) + '-';
            string month = date.Substring(indexM, 3);

            for (int i = 0; i < months.Length; i++)
            {
                if (months[i] == month)
                {
                    if (i + 1 < 10)
                        result += '0';
                    result += (i + 1) + "-";
                    break;
                }
            }

            if (countD == 1)
                result += '0';
            result += date.Substring(0, countD);

            return result;
        }
}