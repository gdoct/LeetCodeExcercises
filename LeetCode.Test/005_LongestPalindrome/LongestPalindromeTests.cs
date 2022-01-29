using LeetCode.Impl.LongestPalindrome;
using Xunit;

namespace LeetCode.Test.LongestPalindrome;

public class LongestPalindromeTests
{
    [Theory]
    [InlineData("abba", "bb")]
    [InlineData("", "")]
    [InlineData("kfdjhahkasdfggfdsasajhhhfdsjjdfkjd", "asdfggfdsa")]
    public void Test1(string s, string expected)
    {
        var m = new Solution();
        var result = m.LongestPalindrome(s);
        Assert.Equal(expected, result);
    }
}