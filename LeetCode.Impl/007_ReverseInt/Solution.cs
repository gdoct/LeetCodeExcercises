namespace LeetCode.Impl.ReverseInt;
/*
 7. Reverse Integer (medium)

Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

 

Example 1:

Input: x = 123
Output: 321
Example 2:

Input: x = -123
Output: -321
Example 3:

Input: x = 120
Output: 21
 

Constraints:

-231 <= x <= 231 - 1
 */
internal class Solution
{
    public int Reverse(int x)
    {
        var array = IntToArray(x);
        long result = 0;
        var arraylen = array.Length;
        for (int i = 0; i < arraylen; i++)
        {
            var num = array[i];
            var pow = arraylen - (i + 1);
            result += (long)(num * Math.Pow(10, pow));
        }
        if (result >= int.MaxValue) return 0;
        if (result <= int.MinValue) return 0;
        return (int)result;
    }

    private static int[] IntToArray(int n)
    {
        var nums = new List<int>();
        while (true)
        {
            var remainder = n % 10;
            nums.Add(remainder);
            n = (n - remainder) / 10;
            if (n == 0) return nums.ToArray();
        }
    }
}
