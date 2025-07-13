namespace LeetCodeNet.G0101_0200.S0167_two_sum_ii_input_array_is_sorted {

using Xunit;

public class SolutionTest {
    [Fact]
    public void TwoSum() {
        Assert.Equal(new int[] {1, 2}, new Solution().TwoSum(new int[] {2, 7, 11, 15}, 9));
    }

    [Fact]
    public void TwoSum2() {
        Assert.Equal(new int[] {1, 3}, new Solution().TwoSum(new int[] {2, 3, 4}, 6));
    }

    [Fact]
    public void TwoSum3() {
        Assert.Equal(new int[] {1, 2}, new Solution().TwoSum(new int[] {-1, 0}, -1));
    }
}
}
