namespace LeetCodeNet.G0101_0200.S0137_single_number_ii {

using Xunit;

public class SolutionTest {
    [Fact]
    public void SingleNumber() {
        Assert.Equal(3, new Solution().SingleNumber(new int[] {2, 2, 3, 2}));
    }

    [Fact]
    public void SingleNumber2() {
        Assert.Equal(99, new Solution().SingleNumber(new int[] {0, 1, 0, 1, 0, 1, 99}));
    }
}
}
