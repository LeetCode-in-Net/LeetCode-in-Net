namespace LeetCodeNet.G0101_0200.S0131_palindrome_partitioning {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Partition() {
        Assert.Equal(
            new List<IList<string>> {
                new List<string> {"a", "a", "b"},
                new List<string> {"aa", "b"}
            },
            new Solution().Partition("aab"));
    }

    [Fact]
    public void Partition2() {
        Assert.Equal(
            new List<IList<string>> {new List<string> {"a"}},
            new Solution().Partition("a"));
    }
}
}
