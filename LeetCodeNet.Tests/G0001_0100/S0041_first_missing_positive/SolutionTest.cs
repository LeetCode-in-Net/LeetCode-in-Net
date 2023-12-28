namespace LeetCodeNet.G0001_0100.S0041_first_missing_positive {

using Xunit;

public class SolutionTest {
    [Fact]
    public void FirstMissingPositive() {
        Assert.Equal(3, new Solution().FirstMissingPositive(new int[] {1, 2, 0}));
    }

    [Fact]
    public void FirstMissingPositive2() {
        Assert.Equal(2, new Solution().FirstMissingPositive(new int[] {3, 4, -1, 1}));
    }

    [Fact]
    public void FirstMissingPositive3() {
        Assert.Equal(1, new Solution().FirstMissingPositive(new int[] {7, 8, 9, 11, 12}));
    }
}
}
