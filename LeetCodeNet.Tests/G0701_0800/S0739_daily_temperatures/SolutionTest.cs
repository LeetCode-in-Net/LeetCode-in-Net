namespace LeetCodeNet.G0701_0800.S0739_daily_temperatures {

using Xunit;

public class SolutionTest {
    [Fact]
    public void DailyTemperatures() {
        Assert.Equal(new int[] {1, 1, 4, 2, 1, 1, 0, 0}, new Solution().DailyTemperatures(new int[] {73, 74, 75, 71, 69, 72, 76, 73}));
    }

    [Fact]
    public void DailyTemperatures2() {
        Assert.Equal(new int[] {1, 1, 1, 0}, new Solution().DailyTemperatures(new int[] {30, 40, 50, 60}));
    }

    [Fact]
    public void DailyTemperatures3() {
        Assert.Equal(new int[] {1, 1, 0}, new Solution().DailyTemperatures(new int[] {30, 60, 90}));
    }
}
}
