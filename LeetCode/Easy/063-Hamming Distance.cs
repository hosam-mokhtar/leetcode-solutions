Link: https://leetcode.com/problems/hamming-distance/
Language: C#



public class Solution {
        public int HammingDistance(int x, int y)
        {
           return int.PopCount(x^y);
        }
}