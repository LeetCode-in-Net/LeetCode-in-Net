namespace LeetCodeNet.G0001_0100.S0075_sort_colors {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Sorting #Two_Pointers
// #Data_Structure_II_Day_2_Array #Udemy_Arrays #Big_O_Time_O(n)_Space_O(1)
// #2025_06_13_Time_0_ms_(100.00%)_Space_46.46_MB_(73.50%)

public class Solution {
    public void SortColors(int[] nums) {
        int zeroes = 0;
        int ones = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                nums[zeroes++] = 0;
            } else if (nums[i] == 1) {
                ones++;
            }
        }
        for (int j = zeroes; j < zeroes + ones; j++) {
            nums[j] = 1;
        }
        for (int k = zeroes + ones; k < nums.Length; k++) {
            nums[k] = 2;
        }
    }
}
}
