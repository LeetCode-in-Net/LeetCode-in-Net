namespace LeetCodeNet.G0001_0100.S0053_maximum_subarray {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #Array #Dynamic_Programming
// #Divide_and_Conquer #Data_Structure_I_Day_1_Array #Dynamic_Programming_I_Day_5
// #Udemy_Famous_Algorithm #Big_O_Time_O(n)_Space_O(1)
// #2024_01_11_Time_270_ms_(38.35%)_Space_62.7_MB_(7.88%)

public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int curSum = 0;
        for (int i = 0; i < nums.Length; i++) {
            curSum += nums[i];
            maxSum = Math.Max(curSum, maxSum);
            if (curSum < 0) {
                curSum = 0;
            }
        }
        return maxSum;
    }
}
}
