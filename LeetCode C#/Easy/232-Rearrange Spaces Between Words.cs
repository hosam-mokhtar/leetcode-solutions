Link: https://leetcode.com/problems/rearrange-spaces-between-words/
Language: C#






public class Solution {
        public string ReorderSpaces(string text)
        {
            List<string> list = [];
            string temp = "";
            int c = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                    temp += text[i];
                else
                {
                    if (temp.Length > 0)
                    {
                        list.Add(temp);
                        temp = "";
                    }
                    c++;
                }
            }
            if (c == 0)
                return text;

            if (temp.Length > 0)
                list.Add(temp);

            int spaces = 0;
            
            if (list.Count > 1)
                spaces = c / (list.Count - 1);
            else
                spaces = c;

            StringBuilder sb = new();
            int tempC = spaces;

            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);

                if (i < list.Count - 1)
                    while (tempC > 0)
                    {
                        sb.Append(" ");
                        tempC--;
                        c--;
                    }

                tempC = spaces;
            }

            while (c > 0)
            {
                sb.Append(" ");
                c--;
            }

            return sb.ToString();
        }
}