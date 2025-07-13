namespace LeetCodeNet.G0201_0300.S0202_happy_number {

using Xunit;

public class SolutionTest {
    [Fact]
    public void IsHappy() {
        Assert.True(new Solution().IsHappy(19));
    }

    [Fact]
    public void IsHappy2() {
        Assert.False(new Solution().IsHappy(2));
    }
}
}
