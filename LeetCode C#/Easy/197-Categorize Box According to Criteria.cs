Link: https://leetcode.com/problems/categorize-box-according-to-criteria/
Language: C#






public class Solution {
        public string CategorizeBox(int length, int width, int height, int mass)
        {
            bool bulky = length >= 10_000 ||
                         width >= 10_000 || 
                         height >= 10_000 ||
                         (long)length * width * height >= 1_000_000_000;

            bool heavy = mass >= 100;

            return bulky && heavy ? "Both"
                 : bulky ? "Bulky"
                 : heavy ? "Heavy"
                 : "Neither";
        }
}