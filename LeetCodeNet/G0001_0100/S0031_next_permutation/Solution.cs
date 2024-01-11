namespace LeetCodeNet.G0001_0100.S0031_next_permutation {

// #Medium #Top_100_Liked_Questions #Array #Two_Pointers #Big_O_Time_O(n)_Space_O(1)
// #2024_01_11_Time_98_ms_(94.17%)_Space_46_MB_(24.35%)

public class Solution {
    public void NextPermutation(int[] nums) {
        if (nums == null || nums.Length <= 1) {
            return;
        }
        int i = nums.Length - 2;
        while (i >= 0 && nums[i] >= nums[i + 1]) {
            i--;
        }
        if (i >= 0) {
            int j = nums.Length - 1;
            while (nums[j] <= nums[i]) {
                j--;
            }
            Swap(nums, i, j);
        }
        Reverse(nums, i + 1, nums.Length - 1);
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    private void Reverse(int[] nums, int i, int j) {
        while (i < j) {
            Swap(nums, i++, j--);
        }
    }
}
}
