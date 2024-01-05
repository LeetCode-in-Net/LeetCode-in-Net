namespace LeetCodeNet.G0401_0500.S0416_partition_equal_subset_sum {

// #Medium #Top_100_Liked_Questions #Array #Dynamic_Programming #Level_2_Day_13_Dynamic_Programming
// #Big_O_Time_O(n*sums)_Space_O(n*sums) #2024_01_05_Time_95_ms_(97.38%)_Space_42.9_MB_(84.72%)

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
