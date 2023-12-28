namespace LeetCodeNet.G0001_0100.S0034_find_first_and_last_position_of_element_in_sorted_array {

using Xunit;

public class SolutionTest {
    [Fact]
    public void SearchRange() {
        int[] expected = new int[] {3, 4};
        int[] actual = new Solution().SearchRange(new int[] {5, 7, 7, 8, 8, 10}, 8);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SearchRange2() {
        int[] expected = new int[] {-1, -1};
        int[] actual = new Solution().SearchRange(new int[] {5, 7, 7, 8, 8, 10}, 6);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SearchRange3() {
        int[] expected = new int[] {-1, -1};
        int[] actual = new Solution().SearchRange(new int[] {}, 0);
        Assert.Equal(expected, actual);
    }
}
}
