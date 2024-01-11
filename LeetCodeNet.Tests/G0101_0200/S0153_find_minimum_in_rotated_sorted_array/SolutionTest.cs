namespace LeetCodeNet.G0101_0200.S0153_find_minimum_in_rotated_sorted_array {

using Xunit;

public class SolutionTest {
    [Fact]
    public void FindMin() {
        Assert.Equal(1, new Solution().FindMin(new int[] {3, 4, 5, 1, 2}));
    }

    [Fact]
    public void FindMin2() {
        Assert.Equal(0, new Solution().FindMin(new int[] {4, 5, 6, 7, 0, 1, 2}));
    }

    [Fact]
    public void FindMin3() {
        Assert.Equal(11, new Solution().FindMin(new int[] {11, 13, 15, 17}));
    }
}
}
