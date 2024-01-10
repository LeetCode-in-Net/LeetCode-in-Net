namespace LeetCodeNet.G0201_0300.S0215_kth_largest_element_in_an_array {

using Xunit;

public class SolutionTest {
    [Fact]
    public void FindKthLargest() {
        Assert.Equal(5, new Solution().FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2));
    }

    [Fact]
    public void FindKthLargest2() {
        Assert.Equal(4, new Solution().FindKthLargest(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4));
    }
}
}
