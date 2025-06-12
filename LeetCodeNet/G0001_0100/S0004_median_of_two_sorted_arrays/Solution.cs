namespace LeetCodeNet.G0001_0100.S0004_median_of_two_sorted_arrays {

// #Hard #Top_100_Liked_Questions #Top_Interview_Questions #Array #Binary_Search #Divide_and_Conquer
// #Top_Interview_150_Binary_Search #Big_O_Time_O(log(min(N,M)))_Space_O(1)
// #AI_can_be_used_to_solve_the_task #2025_06_12_Time_0_ms_(100.00%)_Space_55.92_MB_(53.97%)

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums2.Length < nums1.Length) {
            return FindMedianSortedArrays(nums2, nums1);
        }
        int cut1;
        int cut2;
        int n1 = nums1.Length;
        int n2 = nums2.Length;
        int low = 0;
        int high = n1;
        while (low <= high) {
            cut1 = (low + high) / 2;
            cut2 = ((n1 + n2 + 1) / 2) - cut1;
            int l1 = cut1 == 0 ? int.MinValue : nums1[cut1 - 1];
            int l2 = cut2 == 0 ? int.MinValue : nums2[cut2 - 1];
            int r1 = cut1 == n1 ? int.MaxValue : nums1[cut1];
            int r2 = cut2 == n2 ? int.MaxValue : nums2[cut2];
            if (l1 <= r2 && l2 <= r1) {
                if ((n1 + n2) % 2 == 0) {
                    return (Math.Max(l1, l2) + Math.Min(r1, r2)) / 2.0;
                }
                return Math.Max(l1, l2);
            } else if (l1 > r2) {
                high = cut1 - 1;
            } else {
                low = cut1 + 1;
            }
        }
        return 0.0;
    }
}
}
