Link: https://leetcode.com/problems/factorial-trailing-zeroes/
Language: C#




public class Solution {
    public int TrailingZeroes(int n) {
        int count = 0;
        while(n>=5){
            n = n/5;
            count +=n;
        }
        return count;     
    }
}