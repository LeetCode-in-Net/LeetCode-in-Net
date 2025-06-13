namespace LeetCodeNet.G0001_0100.S0056_merge_intervals {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Sorting
// #Data_Structure_II_Day_2_Array #Level_2_Day_17_Interval #Udemy_2D_Arrays/Matrix
// #Top_Interview_150_Intervals #Big_O_Time_O(n_log_n)_Space_O(n)
// #2025_06_13_Time_6_ms_(39.00%)_Space_56.11_MB_(92.27%)

public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        for (int i = 1; i < intervals.Length; i++) {
            if (intervals[i][0] <= intervals[i - 1][1]) {
                intervals[i][0] = intervals[i - 1][0];
                intervals[i][1] = Math.Max(intervals[i - 1][1], intervals[i][1]);
                intervals[i - 1][0] = -1;
            }
        }
        return intervals.Where(obj => obj[0] != -1).ToArray();
    }
}
}
