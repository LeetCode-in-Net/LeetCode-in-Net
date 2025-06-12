namespace LeetCodeNet.G0001_0100.S0035_search_insert_position {

// #Easy #Top_100_Liked_Questions #Array #Binary_Search #Algorithm_I_Day_1_Binary_Search
// #Binary_Search_I_Day_2 #Top_Interview_150_Binary_Search #Big_O_Time_O(log_n)_Space_O(1)
// #2025_06_12_Time_0_ms_(100.00%)_Space_43.13_MB_(61.70%)

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int lo = 0;
        int hi = nums.Length - 1;
        while (lo <= hi) {
            int mid = lo + (hi - lo) / 2;
            if (target == nums[mid]) {
                return mid;
            } else if (target < nums[mid]) {
                hi = mid - 1;
            } else if (target > nums[mid]) {
                lo = mid + 1;
            }
        }
        return lo;
    }
}
}
