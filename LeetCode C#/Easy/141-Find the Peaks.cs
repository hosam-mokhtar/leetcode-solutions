Link: https://leetcode.com/problems/find-the-peaks/
Language: C#








public class Solution {
        public IList<int> FindPeaks(int[] mountain)
        {
            List<int> list = [];

            for (int i = 1; i < mountain.Length - 1; i++)
            {

                if (mountain[i] > mountain[i - 1] && mountain[i] > mountain[i + 1])
                    list.Add(i);
            }
            
            return list;
        }
}