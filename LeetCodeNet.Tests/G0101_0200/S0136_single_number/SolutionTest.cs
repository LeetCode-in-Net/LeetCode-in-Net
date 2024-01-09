namespace LeetCodeNet.G0101_0200.S0136_single_number {

using Xunit;

public class SolutionTest {
    [Fact]
    public void SingleNumber() {
        Assert.Equal(1, new Solution().SingleNumber(new int[] {2, 2, 1}));
    }

    [Fact]
    public void SingleNumber2() {
        Assert.Equal(4, new Solution().SingleNumber(new int[] {4, 1, 2, 1, 2}));
    }

    [Fact]
    public void SingleNumber3() {
        Assert.Equal(1, new Solution().SingleNumber(new int[] {1}));
    }
}
}
