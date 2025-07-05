namespace LeetCodeNet.G0001_0100.S0097_interleaving_string {

using Xunit;

public class SolutionTest {
    [Fact]
    public void IsInterleave() {
        var solution = new Solution();
        Assert.True(solution.IsInterleave("aabcc", "dbbca", "aadbbcbcac"));
    }

    [Fact]
    public void IsInterleave2() {
        var solution = new Solution();
        Assert.False(solution.IsInterleave("aabcc", "dbbca", "aadbbbaccc"));
    }

    [Fact]
    public void IsInterleave3() {
        var solution = new Solution();
        Assert.True(solution.IsInterleave("", "", ""));
    }

    [Fact]
    public void IsInterleave4() {
        var solution = new Solution();
        Assert.False(solution.IsInterleave("a", "b", "abc"));
    }
}
}
