Link: https://leetcode.com/problems/construct-the-rectangle/description/
Language: C#



public class Solution {
public int[] ConstructRectangle(int area)
        {
            int x = 0;
            // square root 16 is 4
            // 16/4=4 is correct 
            // 16/3=5.3333
            // 16/2=8
            // 16/1=16
            int i = (int)Math.Sqrt(area);
            while ( i<area) {
              x=  area / i;
                if (x*i == area)
                    return new int[] { x,i};
                i--;
            }
            return new int[] {area,1};  
        }
}