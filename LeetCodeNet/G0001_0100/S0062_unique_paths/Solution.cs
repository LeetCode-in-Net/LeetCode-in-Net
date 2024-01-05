namespace LeetCodeNet.G0001_0100.S0062_unique_paths {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Dynamic_Programming #Math
// #Combinatorics #Algorithm_II_Day_13_Dynamic_Programming #Dynamic_Programming_I_Day_15
// #Level_1_Day_11_Dynamic_Programming #Big_O_Time_O(m*n)_Space_O(m*n)
// #2024_01_05_Time_16_ms_(93.42%)_Space_26.2_MB_(96.08%)

public class Solution {
    public int UniquePaths(int m, int n) {
        int[] array = new int[n];
        for (int i = 0; i < n; i++) {
            array[i] = 1;
        }
        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                array[j] = array[j] + array[j - 1];
            }
        }
        return array[n - 1];
    }
}
}
