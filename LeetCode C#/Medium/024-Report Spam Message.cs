Link: https://leetcode.com/problems/report-spam-message/
Language: C#






public class Solution {
        public bool ReportSpam(string[] message, string[] bannedWords)
        {
            byte counter = 0;
            HashSet<string> spamwords = new HashSet<string>(bannedWords);

            for (int i = 0; i < message.Length; i++)
            {
                if (spamwords.Contains(message[i]))
                    counter++;
                if (counter == 2)
                    return true;
            }

            return false;
        }
}