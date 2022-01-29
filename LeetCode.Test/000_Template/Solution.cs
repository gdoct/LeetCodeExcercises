using System;
using Xunit;
using LeetCode.Impl.Template;

namespace LeetCode.Test.Template;

public class SolutionTests
{
    [Theory]
    [InlineData(null)]
    public void TestSomething(string? value)
    {
        _ = new Solution();
        Assert.Null(value);
    }
}
