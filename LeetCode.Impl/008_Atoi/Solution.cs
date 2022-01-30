namespace LeetCode.Impl.Atoi;

public class Solution
{
    public int MyAtoi(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;
        var inp = s.Trim();
        if (inp.Length == 0) return 0;
        var start = 0;
        var neg = inp[0] == '-';
        if (neg) start = 1;
        else if (inp[0] == '+') start = 1;
        var end = start;
        var len = inp.Length;
        bool nonNulFound = false;
        while (end < len)
        {
            if (char.IsDigit(inp[end]))
            {
                if (!nonNulFound && inp[end] == '0')
                    start++;
                else nonNulFound = true;
                end++;
            }
            else break;
        }

        if (end - start > 10)
        {
            return neg ? int.MinValue : int.MaxValue;
        }

        long result = 0;
        long multiplier = 1;
        for (int n = end - 1; n >= start; n--)
        {
            var num = ConvertLetter(inp[n]) * multiplier;
            result += num;
            if (result > int.MaxValue)
            {
                break;
            }
            multiplier *= 10;
        }
        int finalresult = result > int.MaxValue ? neg ? int.MinValue : int.MaxValue : (int)result;
        if (neg) finalresult *= -1;
        return finalresult;
    }

    static int ConvertLetter(char c)
    {
        return c switch
        {
            '0' => 0,
            '1' => 1,
            '2' => 2,
            '3' => 3,
            '4' => 4,
            '5' => 5,
            '6' => 6,
            '7' => 7,
            '8' => 8,
            '9' => 9,
            _ => -1,
        };
    }
}
