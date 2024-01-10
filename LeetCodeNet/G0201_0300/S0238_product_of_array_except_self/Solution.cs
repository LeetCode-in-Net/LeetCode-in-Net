namespace LeetCodeNet.G0201_0300.S0238_product_of_array_except_self {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Prefix_Sum
// #Data_Structure_II_Day_5_Array #Udemy_Arrays #Big_O_Time_O(n^2)_Space_O(n)
// #2024_01_10_Time_141_ms_(94.24%)_Space_58.3_MB_(10.01%)

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1;
        int[] ans = new int[nums.Length];
        foreach (int num in nums) {
            product = product * num;
        }
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                ans[i] = product / nums[i];
            } else {
                int p = 1;
                for (int j = 0; j < nums.Length; j++) {
                    if (j != i) {
                        p = p * nums[j];
                    }
                }
                ans[i] = p;
            }
        }
        return ans;
    }
}
}
