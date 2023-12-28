namespace LeetCodeNet.G0001_0100.S0033_search_in_rotated_sorted_array {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Search() {
        Assert.Equal(4, new Solution().Search(new int[] {4, 5, 6, 7, 0, 1, 2}, 0));
    }

    [Fact]
    public void Search2() {
        Assert.Equal(-1, new Solution().Search(new int[] {4, 5, 6, 7, 0, 1, 2}, 3));
    }

    [Fact]
    public void Search3() {
        Assert.Equal(-1, new Solution().Search(new int[] {1}, 0));
    }
}
}
