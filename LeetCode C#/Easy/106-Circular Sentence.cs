Link: https://leetcode.com/problems/circular-sentence/
Language: C#






public class Solution {
        public bool IsCircularSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            if (words.Length == 1 && sentence[0] != sentence[sentence.Length - 1])
                return false;
            if (words[0][0] != words[words.Length - 1][words[words.Length - 1].Length - 1])
                return false;
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i][words[i].Length - 1] != words[i + 1][0])
                    return false;
            }
            return true;
        }
}