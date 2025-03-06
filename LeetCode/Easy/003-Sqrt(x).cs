Link: https://leetcode.com/problems/sqrtx/
Language: C#





public class Solution {
    public int MySqrt(int x)
 {
            if (x == 0 || x == 1) return x;
            int left = 1;
            int right = x;
            while (left <= right) {
                int mid = (left+right) / 2;
                if (mid == x / mid)
                    return mid;
                else if (x / mid > mid)
                    left = mid + 1;
                else
                    right = mid - 1;    
            }
                return right;    // right is the floor of the square root
     // return (int)Math.Sqrt(x);
     // or
     // return (int)Math.Pow(x,0.5);   
 }
}