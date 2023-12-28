namespace LeetCodeNet.G0001_0100.S0042_trapping_rain_water {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Trap() {
        Assert.Equal(6, new Solution().Trap(new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1}));
    }

    [Fact]
    public void Trap2() {
        Assert.Equal(9, new Solution().Trap(new int[] {4, 2, 0, 3, 2, 5}));
    }
}
}
