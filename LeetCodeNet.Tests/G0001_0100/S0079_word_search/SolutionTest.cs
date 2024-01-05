namespace LeetCodeNet.G0001_0100.S0079_word_search {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void Exist() {
        var input = new char[][] { new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } };
        Assert.True(new Solution().Exist(input, "ABCCED"));
    }

    [Fact]
    public void Exist2() {
        var input = new char[][] { new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } };
        Assert.True(new Solution().Exist(input, "SEE"));
    }

    [Fact]
    public void Exist3() {
        var input = new char[][] { new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } };
        Assert.False(new Solution().Exist(input, "ABCB"));
    }
}
}
