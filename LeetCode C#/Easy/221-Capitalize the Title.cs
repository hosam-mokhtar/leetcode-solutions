Link: https://leetcode.com/problems/capitalize-the-title/
Language: C#






public class Solution {
        public string CapitalizeTitle(string title)
        {
            StringBuilder sb = new();
            string[] words = title.Split(' ');
            
            for (int i = 0; i < words.Length; i++)
            {
                string temp = words[i].ToLowerInvariant();

                if (temp.Length < 3)
                    sb.Append(temp);
                else
                    sb.Append(temp[0].ToString().ToUpperInvariant() + temp.Substring(1));

                if (i < words.Length - 1)
                    sb.Append(' ');
            }

            return sb.ToString();
        }
}