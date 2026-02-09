Link: https://leetcode.com/problems/distance-between-bus-stops/
Language: C#







public class Solution {
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            if (start == destination)
                return 0;

            int sum = 0, total = 0;

            if (start > destination)
                (start, destination) = (destination, start);

            for (int i = 0; i < distance.Length; i++)
            {
                if (i >= start && i < destination)
                    sum += distance[i];
                
                total += distance[i];
            }

            return Math.Min(sum, total - sum);
        }
}