using System;
using Xunit;

namespace LeetCode.Test.Template;

public class SolutionTests
{
    [Theory]
    [InlineData(null)]
    public void TestSomething(string s)
    {
        if (s is null)
        {
            throw new ArgumentNullException(nameof(s));
        }
    }
}
