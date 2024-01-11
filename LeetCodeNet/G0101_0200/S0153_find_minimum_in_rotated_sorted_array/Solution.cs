namespace LeetCodeNet.G0101_0200.S0153_find_minimum_in_rotated_sorted_array {

// #Medium #Top_100_Liked_Questions #Array #Binary_Search #Algorithm_II_Day_2_Binary_Search
// #Binary_Search_I_Day_12 #Udemy_Binary_Search #Big_O_Time_O(log_N)_Space_O(log_N)
// #2024_01_11_Time_64_ms_(88.59%)_Space_40.9_MB_(17.68%)

public class Solution {
    private int FindMinUtil(int[] nums, int l, int r) {
        if (l == r) {
            return nums[l];
        }
        int mid = (l + r) / 2;
        if (mid == l && nums[mid] < nums[r]) {
            return nums[l];
        }
        if (mid - 1 >= 0 && nums[mid - 1] > nums[mid]) {
            return nums[mid];
        }
        if (nums[mid] < nums[l]) {
            return FindMinUtil(nums, l, mid - 1);
        } else if (nums[mid] > nums[r]) {
            return FindMinUtil(nums, mid + 1, r);
        }
        return FindMinUtil(nums, l, mid - 1);
    }

    public int FindMin(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        return FindMinUtil(nums, l, r);
    }
}
}
