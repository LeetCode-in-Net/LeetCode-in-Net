namespace LeetCodeNet.G0001_0100.S0080_remove_duplicates_from_sorted_array_ii {
    
using Xunit;

public class SolutionTest {
    [Fact]
    public void RemoveDuplicates() {
        var solution = new Solution();
        int[] nums = {1,1,1,2,2,3};
        int k = solution.RemoveDuplicates(nums);
        Assert.Equal(5, k);
        Assert.Equal(new int[] {1,1,2,2,3}, nums[..k]);
    }

    [Fact]
    public void RemoveDuplicates2() {
        var solution = new Solution();
        int[] nums = {0,0,1,1,1,1,2,3,3};
        int k = solution.RemoveDuplicates(nums);
        Assert.Equal(7, k);
        Assert.Equal(new int[] {0,0,1,1,2,3,3}, nums[..k]);
    }

    [Fact]
    public void RemoveDuplicates3() {
        var solution = new Solution();
        int[] nums = {1,2,3,4};
        int k = solution.RemoveDuplicates(nums);
        Assert.Equal(4, k);
        Assert.Equal(new int[] {1,2,3,4}, nums[..k]);
    }
}
}
