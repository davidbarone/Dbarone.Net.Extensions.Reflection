using Xunit;
using System;

namespace Dbarone.Net.Extensions.Reflection.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("123", typeof(int), 123)]
    [InlineData("true", typeof(bool), true)]
    [InlineData("123.45", typeof(float), 123.45f)]
    public void TestParse(string input, Type type, object expected)
    {
        Assert.Equal(expected, type.Parse(input));
    }
}