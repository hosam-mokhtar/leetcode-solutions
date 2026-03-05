Link: https://leetcode.com/problems/hexadecimal-and-hexatrigesimal-conversion/
Language: C#







public class Solution {
    public string ConcatHex36(int n)
    {
        return ToBase(n * n, 16) + ToBase(n * n * n, 36);
    }
    private string ToBase(int num, int size)
    {
        if (num == 0)
            return "0";

        var digits = "0123456789ABCDEF";

        if (size == 36)
            digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        var result = "";

        while (num > 0)
        {
            result = digits[num % size] + result;
            num = num / size;
        }

        return result;
    }
}