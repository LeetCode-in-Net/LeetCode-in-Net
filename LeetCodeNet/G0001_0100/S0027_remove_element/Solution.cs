namespace LeetCodeNet.G0001_0100.S0027_remove_element {

// #Easy #Array #Two_Pointers #Top_Interview_150_Array/String
// #2025_06_30_Time_0_ms_(100.00%)_Space_46.85_MB_(71.67%)

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
        for (int j = 0; j < nums.Length; j++) {
            if (nums[j] != val) {
                nums[i] = nums[j];
                i++;
            }
        }
        return i;
    }
}
}
