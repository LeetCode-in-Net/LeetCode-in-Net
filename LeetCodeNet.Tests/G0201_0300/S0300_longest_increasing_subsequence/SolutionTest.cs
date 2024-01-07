namespace LeetCodeNet.G0201_0300.S0300_longest_increasing_subsequence {

using Xunit;

public class SolutionTest {
    [Fact]
    public void LengthOfLIS() {
        Assert.Equal(4, new Solution().LengthOfLIS(new int[] {10, 9, 2, 5, 3, 7, 101, 18}));
    }

    [Fact]
    public void LengthOfLIS2() {
        Assert.Equal(4, new Solution().LengthOfLIS(new int[] {0, 1, 0, 3, 2, 3}));
    }

    [Fact]
    public void LengthOfLIS3() {
        Assert.Equal(1, new Solution().LengthOfLIS(new int[] {7, 7, 7, 7, 7, 7, 7}));
    }
}
}
