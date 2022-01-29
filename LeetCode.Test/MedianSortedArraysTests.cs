using LeetCode.Impl;
using Xunit;

namespace LeetCode.Test;

public class MedianSortedArraysTests
{
    [Theory]
    [InlineData(new[] { 1, 3 }, new[] { 2 }, 2)]
    [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
    public void Test1(int[] a1, int[] a2, double expected)
    {
        var m = new MedianSortedArrays();
        var result = m.FindMedianSortedArrays(a1, a2);
        Assert.Equal(expected, result);
    }
}
