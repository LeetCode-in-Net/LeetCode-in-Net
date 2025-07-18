namespace LeetCodeNet.G0401_0500.S0433_minimum_genetic_mutation {

using Xunit;

public class SolutionTest {
    [Fact]
    public void MinMutation() {
        Assert.Equal(1, new Solution().MinMutation("AACCGGTT", "AACCGGTA", new string[] {"AACCGGTA"}));
    }

    [Fact]
    public void MinMutation2() {
        Assert.Equal(2,
            new Solution()
                .MinMutation(
                    "AACCGGTT",
                    "AAACGGTA",
                    new string[] {"AACCGGTA", "AACCGCTA", "AAACGGTA"}));
    }

    [Fact]
    public void MinMutation3() {
        Assert.Equal(3,
            new Solution()
                .MinMutation(
                    "AAAAACCC",
                    "AACCCCCC",
                    new string[] {"AAAACCCC", "AAACCCCC", "AACCCCCC"}));
    }
}
}
