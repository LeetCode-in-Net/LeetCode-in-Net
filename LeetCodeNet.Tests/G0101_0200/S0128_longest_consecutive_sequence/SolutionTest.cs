namespace LeetCodeNet.G0101_0200.S0128_longest_consecutive_sequence {

using Xunit;

public class SolutionTest {
    [Fact]
    public void LongestConsecutive() {
        Assert.Equal(4, new Solution().LongestConsecutive(new int[] {100, 4, 200, 1, 3, 2}));
    }

    [Fact]
    public void LongestConsecutive2() {
        Assert.Equal(9, new Solution().LongestConsecutive(new int[] {0, 3, 7, 2, 5, 8, 4, 6, 0, 1}));
    }
}
}
