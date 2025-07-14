namespace LeetCodeNet.G0201_0300.S0209_minimum_size_subarray_sum {

// #Medium #Array #Binary_Search #Prefix_Sum #Sliding_Window #Algorithm_II_Day_5_Sliding_Window
// #Binary_Search_II_Day_1 #Top_Interview_150_Sliding_Window
// #2025_07_14_Time_0_ms_(100.00%)_Space_52.33_MB_(91.45%)

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int i = 0, j = 0, sum = 0, min = int.MaxValue;
        while (j < nums.Length) {
            sum += nums[j];
            if (sum >= target) {
                while (i <= j) {
                    if (sum - nums[i] >= target) {
                        sum -= nums[i];
                        i++;
                    } else {
                        break;
                    }
                }
                if (j - i + 1 < min) {
                    min = j - i + 1;
                }
            }
            j++;
        }
        return min == int.MaxValue ? 0 : min;
    }
}
}
