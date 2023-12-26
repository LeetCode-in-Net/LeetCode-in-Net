namespace LeetCodeNet.G0001_0100.S0022_generate_parentheses {

using Xunit;
using System.Collections.Generic;

public class SolutionTest {
    [Fact]
    public void GenerateParenthesis() {
        Assert.Equal(
            new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" },
            new Solution().GenerateParenthesis(3)
        );
    }

    [Fact]
    public void GenerateParenthesis2() {
        Assert.Equal(
            new List<string> { "()" },
            new Solution().GenerateParenthesis(1)
        );
    }
}
}
