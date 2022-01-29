using LeetCode.Impl.LongestSubstring;
using System;
using Xunit;

namespace LeetCode.Test.LongestSubstring
{
    public class LongestSubstringTests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void LongestSubstringTest(string s, int expected)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.LengthOfLongestSubstring(
                s);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
