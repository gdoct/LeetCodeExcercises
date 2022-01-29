using LeetCode.Impl.AddTwoNumbers;
using System;
using Xunit;

namespace LeetCode.Test.AddTwoNumbers;

public class AddTwoNumbersTests
{
    [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
    [InlineData(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
    [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] {9,9,9,9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    [Theory]
    public void AddTwoNumbers_StateUnderTest_ExpectedBehavior(int[] array, int[] target, int[] expected)
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        if (target is null)
        {
            throw new ArgumentNullException(nameof(target));
        }

        if (expected is null)
        {
            throw new ArgumentNullException(nameof(expected));
        }
        // Arrange
        //var impl = new Solution();

        //var result = impl.AddTwoNumbers(array, target);

        //// Assert
        //Assert.Equal(expected, result);
    }
}
