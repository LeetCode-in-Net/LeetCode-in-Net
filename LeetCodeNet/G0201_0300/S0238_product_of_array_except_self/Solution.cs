namespace LeetCodeNet.G0201_0300.S0238_product_of_array_except_self {

// #Medium #Top_100_Liked_Questions #Array #Prefix_Sum #LeetCode_75_Array/String
// #Data_Structure_II_Day_5_Array #Udemy_Arrays #Top_Interview_150_Array/String
// #Big_O_Time_O(n^2)_Space_O(n) #2025_06_16_Time_1_ms_(100.00%)_Space_66.76_MB_(65.40%)

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
