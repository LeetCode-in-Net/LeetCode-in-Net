namespace LeetCodeNet.G0901_1000.S0918_maximum_sum_circular_subarray {

// #Medium #Array #Dynamic_Programming #Divide_and_Conquer #Queue #Monotonic_Queue
// #Dynamic_Programming_I_Day_5 #Top_Interview_150_Kadane's_Algorithm
// #2025_07_18_Time_2_ms_(38.75%)_Space_52.96_MB_(71.25%)

using System;
using System.Linq;

public class Solution {
    private int Kadane(int[] nums, int sign) {
        int currSum = int.MinValue;
        int maxSum = int.MinValue;
        foreach (int i in nums) {
            currSum = sign * i + Math.Max(currSum, 0);
            maxSum = Math.Max(maxSum, currSum);
        }
        return maxSum;
    }

    public int MaxSubarraySumCircular(int[] nums) {
        if (nums.Length == 1) {
            return nums[0];
        }
        int sumOfArray = 0;
        foreach (int i in nums) {
            sumOfArray += i;
        }
        int maxSumSubarray = Kadane(nums, 1);
        int minSumSubarray = Kadane(nums, -1) * -1;
        // If all numbers are negative, minSumSubarray will be sumOfArray.
        // In this case, the circular sum (sumOfArray - minSumSubarray) would be 0,
        // which is incorrect if the actual answer is the largest negative number.
        // The largest negative number would be captured by maxSumSubarray.
        if (sumOfArray == minSumSubarray) {
            return maxSumSubarray;
        } else {
            return Math.Max(maxSumSubarray, sumOfArray - minSumSubarray);
        }
    }
}
}
