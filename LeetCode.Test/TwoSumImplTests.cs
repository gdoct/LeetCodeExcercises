using LeetCode.Impl;
using Xunit;

namespace LeetCode.Test;

public class TwoSumImplTests
{
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 0 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 2, 1 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 1, 0 })]
    [Theory]
    //[InlineData(new int[] { 2, 7, 11, 15 }, 9)]
    public void TwoSum_StateUnderTest_ExpectedBehavior(int[] array, int target, int[] expected)
    {
        // Arrange
        var twoSumImpl = new TwoSumImpl();

        var result = twoSumImpl.TwoSum(array, target);

        // Assert
        Assert.Equal(expected, result);
    }
}
