Link: https://leetcode.com/problems/reverse-string/
Language: C#





public class Solution {
    public void ReverseString(char[] s) {
          
 Array.Reverse(s);
 Console.Write("[");
 foreach (var x in s)
 {
     Console.Write($"\"{x}\"");

     if (s.Last() == x)
         break;
     else
         Console.Write(",");
 }
 Console.Write("]");
    }
}