Link: https://leetcode.com/problems/uncommon-words-from-two-sentences/
Language: C#




public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        string[] words = (s1 + " " + s2).Split(' ');
        HashSet<string> once = new HashSet<string>();
        HashSet<string> duplicates = new HashSet<string>();
        foreach (string word in words) {
            if (duplicates.Contains(word))
                continue;
            if (!once.Add(word)) {
                once.Remove(word);
                duplicates.Add(word);
            }
        }
        return once.ToArray();
    }
}