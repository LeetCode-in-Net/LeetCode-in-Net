namespace LeetCodeNet.G0401_0500.S0416_partition_equal_subset_sum {

// #Medium #Top_100_Liked_Questions #Array #Dynamic_Programming #Level_2_Day_13_Dynamic_Programming
// #Big_O_Time_O(n*sums)_Space_O(n*sums) #2025_06_16_Time_22_ms_(82.19%)_Space_44.17_MB_(96.67%)

public class Solution {
    public bool CanPartition(int[] nums) {
        int sums = 0;
        foreach (int num in nums) {
            sums += num;
        }
        if (sums % 2 == 1) {
            return false;
        }
        sums /= 2;
        bool[] dp = new bool[sums + 1];
        dp[0] = true;
        foreach (int num in nums) {
            for (int sum = sums; sum >= num; sum--) {
                dp[sum] = dp[sum] || dp[sum - num];
            }
        }
        return dp[sums];
    }
}
}
