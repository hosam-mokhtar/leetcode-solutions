Link: https://leetcode.com/problems/divide-a-string-into-groups-of-size-k/
Language: C#





public class Solution {
public string[] DivideString(string s, int k, char fill)
{

    string[] result = new string[(int)Math.Ceiling((decimal)s.Length / k)];
    int index = 0;

    for (int i = 0; i < s.Length; i += k)
    {
        int counter = 0;
        for (int j = i; j < s.Length; j++)
        {
            if (counter < k)
                result[index] += s[j];
            else
                break;
            counter++;
        }
        index++;
    }
    
    while (result[result.Length - 1].Length < k)
    {
        result[result.Length - 1] += fill;
    }

    return result;
}
}