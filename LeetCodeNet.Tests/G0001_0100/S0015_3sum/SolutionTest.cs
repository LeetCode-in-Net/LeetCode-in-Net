namespace LeetCodeNet.G0001_0100.S0015_3sum {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void ThreeSum() {
        Assert.Equal(
            ArrayUtils.GetLists(new int[][] { new int[] { -1, -1, 2 }, new int[] { -1, 0, 1 } }),
            new Solution().ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 })
        );
    }

    [Fact]
    public void ThreeSum2() {
        Assert.Equal(
            ArrayUtils.GetLists(new int[][] { }),
            new Solution().ThreeSum(new int[] { })
        );
    }

    [Fact]
    public void ThreeSum3() {
        Assert.Equal(
            ArrayUtils.GetLists(new int[][] { }),
            new Solution().ThreeSum(new int[] { 0 })
        );
    }
}
}
