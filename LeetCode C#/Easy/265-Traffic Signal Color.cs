Link: https://leetcode.com/problems/traffic-signal-color/
Language: C#







public class Solution {
        public string TrafficSignal(int timer)
        {
            if (timer == 0)
                return "Green";
            if (timer == 30)
                return "Orange";
            if (timer > 30 && timer <= 90)
                return "Red";
            
            return "Invalid";
        }
}