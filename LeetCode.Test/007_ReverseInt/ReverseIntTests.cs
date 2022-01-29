using LeetCode.Impl.ReverseInt;
using Xunit;

namespace LeetCode.Test.ReverseInt;

public class ReverseIntTests
{
    [Theory]
    [InlineData(-123, -321)]
    [InlineData(123, 321)]
    [InlineData(0, 0)]
    [InlineData(int.MaxValue, 0)]
    public void ReverseNum(int n, int expected)
    {
        // Arrange
        var reverseInt = new Solution();
        // Act
        var result = reverseInt.Reverse(n);

        // Assert
        Assert.Equal(expected, result);
    }
}
