namespace LeetCodeNet.G0101_0200.S0149_max_points_on_a_line {

// #Hard #Top_Interview_Questions #Array #Hash_Table #Math #Geometry #Algorithm_II_Day_21_Others
// #Top_Interview_150_Math #2025_07_12_Time_5_ms_(100.00%)_Space_41.59_MB_(98.57%)

public class Solution {
    public int MaxPoints(int[][] points) {
        if (points.Length < 2) {
            return points.Length;
        }
        int max = 0;
        for (int i = 0; i < points.Length; i++) {
            for (int j = i + 1; j < points.Length; j++) {
                int x = points[j][0] - points[i][0];
                int y = points[j][1] - points[i][1];
                int c = x * points[j][1] - y * points[j][0];
                int count = 2;
                for (int k = j + 1; k < points.Length; k++) {
                    if (c == x * points[k][1] - y * points[k][0]) {
                        count++;
                    }
                }
                max = System.Math.Max(count, max);
            }
        }
        return max;
    }
}
}
