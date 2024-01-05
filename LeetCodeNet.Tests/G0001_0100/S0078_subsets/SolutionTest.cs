namespace LeetCodeNet.G0001_0100.S0078_subsets {

using Xunit;
using System.Collections.Generic;
using System.Linq;

public class SolutionTest {
    [Fact]
    public void Subsets() {
        int[][] expected = new int[][] {new int[] {}, new int[] {1},
            new int[] {1, 2}, new int[] {1, 2, 3}, new int[] {1, 3}, new int[] {2}, new int[] {2, 3}, new int[] {3}};
        Assert.Equal(expected, new Solution().Subsets(new int[] {1, 2, 3}).Select(a => a.ToArray()).ToArray());
    }

    [Fact]
    public void Subsets2() {
        int[][] expected = new int[][] {new int[] {}, new int[] {0}};
        Assert.Equal(expected, new Solution().Subsets(new int[] {0}).Select(a => a.ToArray()).ToArray());
    }
}
}
