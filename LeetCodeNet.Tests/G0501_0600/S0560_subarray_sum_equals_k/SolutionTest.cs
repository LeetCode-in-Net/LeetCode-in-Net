namespace LeetCodeNet.G0501_0600.S0560_subarray_sum_equals_k {

using Xunit;

public class SolutionTest {
    [Fact]
    public void SubarraySum() {
        Assert.Equal(2, new Solution().SubarraySum(new int[] {1, 1, 1}, 2));
    }

    [Fact]
    public void SubarraySum2() {
        Assert.Equal(2, new Solution().SubarraySum(new int[] {1, 2, 3}, 3));
    }
}
}
