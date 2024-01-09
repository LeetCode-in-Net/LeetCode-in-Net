namespace LeetCodeNet.G0101_0200.S0128_longest_consecutive_sequence {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Hash_Table #Union_Find
// #Big_O_Time_O(N_log_N)_Space_O(1) #2024_01_09_Time_201_ms_(61.50%)_Space_61.2_MB_(52.89%)

public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        Array.Sort(nums);
        int max = int.MinValue;
        int thsMax = 1;
        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i + 1] == nums[i] + 1) {
                thsMax += 1;
                continue;
            }
            if (nums[i + 1] == nums[i]) {
                continue;
            }
            // Start of a new Sequene
            max = Math.Max(max, thsMax);
            thsMax = 1;
        }
        return Math.Max(max, thsMax);
    }
}
}
