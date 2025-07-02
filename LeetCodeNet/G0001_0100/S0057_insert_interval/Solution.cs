namespace LeetCodeNet.G0001_0100.S0057_insert_interval {

// #Medium #Array #Level_2_Day_17_Interval #Top_Interview_150_Intervals
// #2025_07_01_Time_1_ms_(99.33%)_Space_51.29_MB_(48.12%)

using System.Collections.Generic;

public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var result = new List<int[]>();
        int i = 0, n = intervals.Length;
        // Add all intervals before newInterval
        while (i < n && intervals[i][1] < newInterval[0]) {
            result.Add(intervals[i++]);
        }
        // Merge overlapping intervals
        while (i < n && intervals[i][0] <= newInterval[1]) {
            newInterval[0] = System.Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = System.Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }
        result.Add(newInterval);
        // Add the rest
        while (i < n) {
            result.Add(intervals[i++]);
        }
        return result.ToArray();
    }
}
}
