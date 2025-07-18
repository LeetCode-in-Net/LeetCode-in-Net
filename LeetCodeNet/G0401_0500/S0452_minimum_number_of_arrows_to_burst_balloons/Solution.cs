namespace LeetCodeNet.G0401_0500.S0452_minimum_number_of_arrows_to_burst_balloons {

// #Medium #Array #Sorting #Greedy #LeetCode_75_Intervals #Top_Interview_150_Intervals
// #2025_07_18_Time_51_ms_(49.35%)_Space_78.67_MB_(21.94%)

using System;
using System.Linq;

public class Solution {
    /*
     * I'm glad to have come up with this solution on my own on 10/13/2021:
     * we'll have to sort the
     * balloons by its ending points, a counter case to this is below:
     * {{0, 6}, {0, 9}, {7, 8}}
     * if we sort by starting points, then it becomes:
     * {0, 6}, {0, 9}, {7, 8}
     * this way, if we shoot 9,
     * {0, 6} won't be burst however, if we sort by ending points, then it becomes:
     * {0, 6}, {7, 8}, {0, 9}, then we shoot at 6, then at 8, this gives us the result of bursting all balloons.
     */
    public int FindMinArrowShots(int[][] points) {
        if (points == null || points.Length == 0) {
            return 0;
        }
        // Sort by the ending point
        Array.Sort(points, (a, b) => {
            // C# does not have Integer.compare.
            // When dealing with int, direct comparison is usually fine.
            // For long, careful casting or using Comparer<long>.Default.Compare might be needed.
            // Here, a[1] and b[1] are int, so direct comparison works.
            return a[1].CompareTo(b[1]);
        });
        int minArrows = 1;
        // Use long to avoid potential overflow if points[1] could be int.MaxValue
        long end = points[0][1];
        for (int i = 1; i < points.Length; i++) {
            // If the current balloon starts after the last arrow's effective end,
            // we need a new arrow.
            if (points[i][0] > end) {
                minArrows++;
                end = points[i][1];
            }
        }
        return minArrows;
    }
}
}
