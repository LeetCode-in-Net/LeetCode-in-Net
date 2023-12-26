namespace LeetCodeNet.G0001_0100.S0011_container_with_most_water {

using Xunit;

public class SolutionTest {
    [Fact]
    public void MaxArea() {
        Assert.Equal(49, new Solution().MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
    }

    [Fact]
    public void MaxArea2() {
        Assert.Equal(1, new Solution().MaxArea(new int[] { 1, 1 }));
    }
}
}
