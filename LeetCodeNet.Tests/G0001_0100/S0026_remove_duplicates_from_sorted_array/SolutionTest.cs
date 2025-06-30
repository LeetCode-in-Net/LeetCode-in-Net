namespace LeetCodeNet.G0001_0100.S0026_remove_duplicates_from_sorted_array {

using Xunit;

public class SolutionTest {
    [Fact]
    public void RemoveDuplicates() {
        var solution = new Solution();
        var nums = new int[] { 1, 1, 2 };
        var expectedNums = new int[] { 1, 2 };
        var k = solution.RemoveDuplicates(nums);
        Assert.Equal(expectedNums.Length, k);
        for (int i = 0; i < k; i++) {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }

    [Fact]
    public void RemoveDuplicates2() {
        var solution = new Solution();
        var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        var expectedNums = new int[] { 0, 1, 2, 3, 4 };
        var k = solution.RemoveDuplicates(nums);
        Assert.Equal(expectedNums.Length, k);
        for (int i = 0; i < k; i++) {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }
}
}
