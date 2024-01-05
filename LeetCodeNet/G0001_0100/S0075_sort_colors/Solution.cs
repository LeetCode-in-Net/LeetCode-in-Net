namespace LeetCodeNet.G0001_0100.S0075_sort_colors {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Sorting #Two_Pointers
// #Data_Structure_II_Day_2_Array #Udemy_Arrays #Big_O_Time_O(n)_Space_O(1)
// #2024_01_05_Time_98_ms_(93.59%)_Space_45.3_MB_(5.46%)

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
