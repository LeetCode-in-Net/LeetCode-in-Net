namespace LeetCodeNet.G0001_0100.S0053_maximum_subarray {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #Array #Dynamic_Programming
// #Divide_and_Conquer #Data_Structure_I_Day_1_Array #Dynamic_Programming_I_Day_5
// #Udemy_Famous_Algorithm #Big_O_Time_O(n)_Space_O(1)
// #2024_01_04_Time_276_ms_(20.05%)_Space_62.4_MB_(8.46%)

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
