namespace LeetCodeNet.G0001_0100.S0078_subsets {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Bit_Manipulation #Backtracking
// #Algorithm_II_Day_9_Recursion_Backtracking #Udemy_Backtracking/Recursion
// #Big_O_Time_O(2^n)_Space_O(n*2^n) #2024_01_05_Time_101_ms_(94.29%)_Space_45.7_MB_(8.93%)

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
