namespace LeetCodeNet.G0001_0100.S0057_insert_interval {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Insert() {
        var solution = new Solution();
        int[][] intervals = new int[][] {
            new int[] {1, 3},
            new int[] {6, 9}
        };
        int[] newInterval = new int[] {2, 5};
        int[][] expected = new int[][] {
            new int[] {1, 5},
            new int[] {6, 9}
        };
        Assert.Equal(expected, solution.Insert(intervals, newInterval));
    }

    [Fact]
    public void Insert2() {
        var solution = new Solution();
        int[][] intervals = new int[][] {
            new int[] {1, 2},
            new int[] {3, 5},
            new int[] {6, 7},
            new int[] {8, 10},
            new int[] {12, 16}
        };
        int[] newInterval = new int[] {4, 8};
        int[][] expected = new int[][] {
            new int[] {1, 2},
            new int[] {3, 10},
            new int[] {12, 16}
        };
        Assert.Equal(expected, solution.Insert(intervals, newInterval));
    }
}
}
