namespace LeetCodeNet.G0001_0100.S0035_search_insert_position {

// #Easy #Top_100_Liked_Questions #Array #Binary_Search #Algorithm_I_Day_1_Binary_Search
// #Binary_Search_I_Day_2 #Big_O_Time_O(log_n)_Space_O(1)
// #2024_01_11_Time_64_ms_(95.18%)_Space_41.4_MB_(28.65%)

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
