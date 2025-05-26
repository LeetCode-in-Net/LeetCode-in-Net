namespace LeetCodeNet.G0101_0200.S0198_house_robber {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Dynamic_Programming
// #LeetCode_75_DP/1D #Algorithm_I_Day_12_Dynamic_Programming #Dynamic_Programming_I_Day_3
// #Level_2_Day_12_Dynamic_Programming #Udemy_Dynamic_Programming #Top_Interview_150_1D_DP
// #Big_O_Time_O(n)_Space_O(n) #2024_01_11_Time_44_ms_(99.89%)_Space_39.8_MB_(13.60%)

public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        if (nums.Length == 1) {
            return nums[0];
        }
        if (nums.Length == 2) {
            return Math.Max(nums[0], nums[1]);
        }
        int[] profit = new int[nums.Length];
        profit[0] = nums[0];
        profit[1] = Math.Max(nums[1], nums[0]);
        for (int i = 2; i < nums.Length; i++) {
            profit[i] = Math.Max(profit[i - 1], nums[i] + profit[i - 2]);
        }
        return profit[nums.Length - 1];
    }
}
}
