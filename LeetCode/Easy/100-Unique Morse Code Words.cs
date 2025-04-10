Link: https://leetcode.com/problems/unique-morse-code-words/
Language: C#






public class Solution {
        public int UniqueMorseRepresentations(string[] words)
        {
            string [] result = {".-", "-...", "-.-.", "-..", ".", "..-.",
                                "--.", "....", "..",".---", "-.-", ".-..",
                                "--", "-.", "---", ".--.", "--.-",".-.",
                                "...", "-", "..-","...-", ".--", "-..-", "-.--", "--.." };
            int counter = 0;
            HashSet<string> set = []; 
            for (int i = 0; i < words.Length; i++) {
                string s = "";
                for (int j = 0; j < words[i].Length; j++)
                {
                        s += result[words[i][j] - 'a'];
                }
                set.Add(s);
            }
                return set.Count;
        }
}