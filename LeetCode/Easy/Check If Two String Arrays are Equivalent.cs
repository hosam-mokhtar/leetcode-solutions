Link: https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/description/
Language: C#




public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
            {
                // Or using StringBuilder
                //string strword1 = "";
                //string strword2 = "";

                //int maxLengthword1 = word1.Sum(word1 => word1.Length);
                //int maxLengthword2 = word1.Sum(word2 => word2.Length);

                //if (maxLengthword1 == maxLengthword2)
                //{
                //    for (int i = 0; i < word1.Length; i++)
                //    {
                //        strword1 += word1[i];

                //    }

                //    for (int i = 0; i < word2.Length; i++)
                //    {
                //        strword2 += word2[i];

                //    }
                //    if (strword1 == strword2)
                //    {
                //        return true;
                //    }
                //}
                //return false;
                return string.Join("", word1) == string.Join("", word2);
            }
}