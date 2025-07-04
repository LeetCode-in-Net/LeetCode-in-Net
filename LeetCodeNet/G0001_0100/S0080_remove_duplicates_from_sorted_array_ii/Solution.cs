namespace LeetCodeNet.G0001_0100.S0080_remove_duplicates_from_sorted_array_ii {

// #Medium #Array #Two_Pointers #Udemy_Arrays #Top_Interview_150_Array/String
// #2025_07_04_Time_125_ms_(97.82%)_Space_53.24_MB_(14.05%)

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 2) {
            return nums.Length;
        }
        int i = 2;
        for (int j = 2; j < nums.Length; j++) {
            if (nums[j] != nums[i - 2]) {
                nums[i++] = nums[j];
            }
        }
        return i;
    }
}
}
