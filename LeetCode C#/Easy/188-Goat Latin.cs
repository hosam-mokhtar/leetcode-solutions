Link: https://leetcode.com/problems/goat-latin/
Language: C#






public class Solution {
        public string ToGoatLatin(string sentence)
        {
            string[] words = sentence.Split(' ');
            StringBuilder sb = new StringBuilder();
            string vowels = "aeiouAEIOU";
            string a = "a";

            for (int i = 0; i < words.Length; i++)
            {
                if (vowels.Contains(words[i][0]) || words[i].Length == 1)
                    sb.Append(words[i]);
                else
                {
                    //sb.Append(words[i].Substring(1, words[i].Length - 1) + words[i][0]);
                    //sb.Append(words[i].Substring(1) + words[i][0]);
                    sb.Append(words[i][1..] + words[i][0]);
                }

                sb.Append("ma" + a);

                if (i + 1 < words.Length)
                {
                    sb.Append(' ');
                    a += 'a';
                }
            }

            return sb.ToString();
        }
}