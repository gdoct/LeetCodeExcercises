using System;
using Xunit;
using LeetCode.Impl.RegEx;

namespace LeetCode.Test.RegEx;

public class RegExTests
{
    [Theory]
    [InlineData("aa", "a", false)]
    [InlineData("aa", "a*", true)]
    [InlineData("ab", ".*", true)]
    [InlineData("asddsa", "asd.*", true)]
    public void TestRegExIsMatch(string s, string p, bool expected)
    {
        var solution = new Solution();
        var result = solution.IsMatch(s, p);
        Assert.Equal(expected, result);
    }
}
