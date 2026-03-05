namespace LeetCodeNet.G0001_0100.S0008_string_to_integer_atoi {

using Xunit;

public class SolutionTest {
    [Fact]
    public void MyAtoi() {
        Assert.Equal(42, Solution.MyAtoi("42"));
    }

    [Fact]
    public void MyAtoi2() {
        Assert.Equal(-42, Solution.MyAtoi("   -42"));
    }

    [Fact]
    public void MyAtoi3() {
        Assert.Equal(4193, Solution.MyAtoi("4193 with words"));
    }

    [Fact]
    public void MyAtoi4() {
        Assert.Equal(0, Solution.MyAtoi("words and 987"));
    }

    [Fact]
    public void MyAtoi5() {
        Assert.Equal(-2147483648, Solution.MyAtoi("-91283472332"));
    }
}
}
