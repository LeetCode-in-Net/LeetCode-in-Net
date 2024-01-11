namespace LeetCodeNet.G0101_0200.S0152_maximum_product_subarray {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Dynamic_Programming
// #Dynamic_Programming_I_Day_6 #Level_2_Day_13_Dynamic_Programming #Udemy_Dynamic_Programming
// #Big_O_Time_O(N)_Space_O(1) #2024_01_11_Time_71_ms_(90.35%)_Space_42.7_MB_(13.88%)

public class Solution {
    public int MaxProduct(int[] nums) {
        int ans = int.MinValue;
        int cprod = 1;
        foreach (int j in nums) {
            cprod = cprod * j;
            ans = Math.Max(ans, cprod);
            if (cprod == 0) {
                cprod = 1;
            }
        }
        cprod = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            cprod = cprod * nums[i];
            ans = Math.Max(ans, cprod);
            if (cprod == 0) {
                cprod = 1;
            }
        }
        return ans;
    }
}
}
