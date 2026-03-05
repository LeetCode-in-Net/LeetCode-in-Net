namespace LeetCodeNet.G0001_0100.S0020_valid_parentheses {

using Xunit;

public class SolutionTest {
    [Fact]
    public void IsValid() {
        Assert.True(Solution.IsValid("()"));
    }

    [Fact]
    public void IsValid2() {
        Assert.True(Solution.IsValid("()[]{}"));
    }

    [Fact]
    public void IsValid3() {
        Assert.False(Solution.IsValid("(]"));
    }

    [Fact]
    public void IsValid4() {
        Assert.False(Solution.IsValid("([)]"));
    }

    [Fact]
    public void IsValid5() {
        Assert.True(Solution.IsValid("{[]}"));
    }
}
}
