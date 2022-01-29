using System;
using Xunit;
using LeetCode.Impl.ZigZagConversion;

namespace LeetCode.Test.ZigZagConversion;

public class ZigZagConversionTests
{
    [Theory]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    public void TestSomething(string s, int rows, string expected)
    {
        var solution = new Solution();
        var result = solution.Convert(s, rows);
        Assert.Equal(expected, result);
    }
}
