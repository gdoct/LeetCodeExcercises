using System;
using Xunit;
using LeetCode.Impl.PalindromeNumber;

namespace LeetCode.Test.PalindromeNumber;

public class SolutionTests
{
    [Theory]
    [InlineData(0, true)]
    [InlineData(5, true)]
    [InlineData(-1, false)]
    [InlineData(969, true)]
    [InlineData(9699, false)]
    public void TestIsPalindrome(int value, bool isPalindrome)
    {
        var solution = new Solution();
        var result = solution.IsPalindrome(value);
        Assert.Equal(isPalindrome, result);
    }
}
