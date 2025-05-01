Link: https://leetcode.com/problems/ransom-note/
Language: C#



public class Solution {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            //  lowercase
            int[] freq = new int[26];
            for (int i = 0; i < magazine.Length; i++)
            {
                freq[magazine[i] - 'a']++;
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (freq[ransomNote[i] - 'a'] > 0)
                    freq[ransomNote[i] - 'a']--;
                else
                    return false;
            }
            return true;
            ///////////////////////////////////////////////////////////////////////
            //Dictionary<char,int>map = new Dictionary<char,int>();
            //for (int i = 0; i < magazine.Length; i++)
            //{
            //    if(!map.ContainsKey(magazine[i]))
            //        map.Add(magazine[i],1);
            //    else
            //        map[magazine[i]]++;
            //}

            //for (int i = 0; i < ransomNote.Length; i++) {
            //    if (map.ContainsKey(ransomNote[i]) && magazine[ransomNote[i]]>0)
            //        map[ransomNote[i]]--;
            //    else
            //        return false;                 
            //}
            //return true;
        }
}