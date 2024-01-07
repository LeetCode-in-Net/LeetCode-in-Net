namespace LeetCodeNet.G0301_0400.S0338_counting_bits {

using Xunit;

public class SolutionTest {
    [Fact]
    public void CountBits() {
        Assert.Equal(new int[] {0, 1, 1}, new Solution().CountBits(2));
    }

    [Fact]
    public void CountBits2() {
        Assert.Equal(new int[] {0, 1, 1, 2, 1, 2}, new Solution().CountBits(5));
    }
}
}
