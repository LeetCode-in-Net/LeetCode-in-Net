namespace LeetCodeNet.G0001_0100.S0035_search_insert_position {

// #Easy #Top_100_Liked_Questions #Array #Binary_Search #Algorithm_I_Day_1_Binary_Search
// #Binary_Search_I_Day_2 #Big_O_Time_O(log_n)_Space_O(1)
// #2023_12_28_Time_106_ms_(6.17%)_Space_42_MB_(5.47%)

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
