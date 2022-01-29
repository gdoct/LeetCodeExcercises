namespace LeetCode.Impl;

internal class ReverseInt 
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
