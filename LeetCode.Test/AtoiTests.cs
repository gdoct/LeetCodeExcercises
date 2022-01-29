using LeetCode.Impl;
using Xunit;

namespace LeetCode.Test;

public class AtoiTests
{
    [Theory]
    [InlineData("-73427342878732", int.MinValue)]
    [InlineData("-1", -1)]
    [InlineData("1", 1)]
    [InlineData("1234", 1234)]
    [InlineData("1234.123", 1234)]
    [InlineData(" -1", -1)]
    [InlineData("4193 with words", 4193)]
    [InlineData("1000000000000000000000000000000000000000000000000000000000000000000000000123", int.MaxValue)]
    [InlineData("  0000000000012345678", 12345678)]
    [InlineData("2147483646", 2147483646)]
    public void Test1(string s, int expected)
    {
        var atoi = new Atoi();
        var result = atoi.MyAtoi(s);
        Assert.Equal(expected, result);
    }
}
