namespace LeetCodeNet.G0001_0100.S0088_merge_sorted_array {

// #Easy #Top_Interview_Questions #Array #Sorting #Two_Pointers #Data_Structure_I_Day_2_Array
// #Top_Interview_150_Array/String #2025_07_05_Time_0_ms_(100.00%)_Space_46.88_MB_(90.46%)

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1; 
        int j = n - 1; 
        int k = m + n - 1;
        while (i >= 0 && j >= 0) {
            if (nums1[i] > nums2[j]) {
                nums1[k--] = nums1[i--];
            } else {
                nums1[k--] = nums2[j--];
            }
        }
        while (j >= 0) {
            nums1[k--] = nums2[j--];
        }
    }
}
}
