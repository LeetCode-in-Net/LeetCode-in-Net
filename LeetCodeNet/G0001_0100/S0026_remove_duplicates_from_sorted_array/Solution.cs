namespace LeetCodeNet.G0001_0100.S0026_remove_duplicates_from_sorted_array {

// #Easy #Top_Interview_Questions #Array #Two_Pointers #Udemy_Two_Pointers
// #Top_Interview_150_Array/String #2025_06_30_Time_0_ms_(100.00%)_Space_50.94_MB_(81.18%)

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        int i = 0;
        for (int j = 1; j < nums.Length; j++) {
            if (nums[j] != nums[i]) {
                i++;
                nums[i] = nums[j];
            }
        }
        return i + 1;
    }
}
}
