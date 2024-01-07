namespace LeetCodeNet.G0501_0600.S0560_subarray_sum_equals_k {

// #Medium #Top_100_Liked_Questions #Array #Hash_Table #Prefix_Sum #Data_Structure_II_Day_5_Array
// #Big_O_Time_O(n)_Space_O(n) #2024_01_07_Time_135_ms_(46.56%)_Space_50.6_MB_(20.87%)

using System.Collections.Generic;

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int tempSum = 0;
        int ret = 0;
        Dictionary<int, int> sumCount = new Dictionary<int, int>();
        sumCount[0] = 1;
        foreach (int i in nums) {
            tempSum += i;
            if (sumCount.ContainsKey(tempSum - k)) {
                ret += sumCount[tempSum - k];
            }
            if (sumCount.ContainsKey(tempSum)) {
                sumCount[tempSum] = sumCount[tempSum] + 1;
            } else {
                sumCount[tempSum] = 1;
            }
        }
        return ret;
    }
}
}
