Link: https://leetcode.com/problems/day-of-the-week/
Language: C#



public class Solution {
 public string DayOfTheWeek(int day, int month, int year)
        {
         //   DateTime dt=new DateTime (year,month,day);
         //   return dt.DayOfWeek.ToString();
         // OR
              var dt=new DateTime (year,month,day);
              return dt.ToString("dddd");
        }
}