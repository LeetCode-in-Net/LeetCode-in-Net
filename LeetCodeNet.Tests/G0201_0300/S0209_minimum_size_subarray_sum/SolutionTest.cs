namespace LeetCodeNet.G0201_0300.S0209_minimum_size_subarray_sum {

using Xunit;

public class SolutionTest {
    [Fact]
    public void MinSubArrayLen() {
        Assert.Equal(2, new Solution().MinSubArrayLen(7, new int[] {2, 3, 1, 2, 4, 3}));
    }

    [Fact]
    public void MinSubArrayLen2() {
        Assert.Equal(1, new Solution().MinSubArrayLen(4, new int[] {1, 4, 4}));
    }

    [Fact]
    public void MinSubArrayLen3() {
        Assert.Equal(0, new Solution().MinSubArrayLen(11, new int[] {1, 1, 1, 1, 1, 1, 1, 1}));
    }
}
}
