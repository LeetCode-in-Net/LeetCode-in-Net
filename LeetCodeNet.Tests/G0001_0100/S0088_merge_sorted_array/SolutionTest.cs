namespace LeetCodeNet.G0001_0100.S0088_merge_sorted_array {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Merge() {
        var solution = new Solution();
        int[] nums1 = {1,2,3,0,0,0};
        int[] nums2 = {2,5,6};
        solution.Merge(nums1, 3, nums2, 3);
        Assert.Equal(new int[] {1,2,2,3,5,6}, nums1);
    }

    [Fact]
    public void Merge2() {
        var solution = new Solution();
        int[] nums1 = {1};
        int[] nums2 = {};
        solution.Merge(nums1, 1, nums2, 0);
        Assert.Equal(new int[] {1}, nums1);
    }

    [Fact]
    public void Merge3() {
        var solution = new Solution();
        int[] nums1 = {0};
        int[] nums2 = {1};
        solution.Merge(nums1, 0, nums2, 1);
        Assert.Equal(new int[] {1}, nums1);
    }
}
}
