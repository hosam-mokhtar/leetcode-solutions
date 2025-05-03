Link: https://leetcode.com/problems/minimum-bit-flips-to-convert-number/
Language: C#






public class Solution {
    public int MinBitFlips(int start, int goal)
    {
        int numOfOperations = 0;
        int xor = start ^ goal;
        while (xor > 0)
        {
            numOfOperations += xor & 1;
            xor >>= 1;
        }
        return numOfOperations;
    }
}