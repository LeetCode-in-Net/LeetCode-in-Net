namespace LeetCodeNet.G0401_0500.S0494_target_sum {

using Xunit;

public class SolutionTest {
    [Fact]
    public void FindTargetSumWays() {
        Assert.Equal(5, new Solution().FindTargetSumWays(new int[] {1, 1, 1, 1, 1}, 3));
    }

    [Fact]
    public void FindTargetSumWays2() {
        Assert.Equal(1, new Solution().FindTargetSumWays(new int[] {1}, 1));
    }
}
}
