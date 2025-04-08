namespace LeetCodeNet.G0101_0200.S0189_rotate_array {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Math #Two_Pointers
// #Algorithm_I_Day_2_Two_Pointers #Udemy_Arrays #Top_Interview_150_Array/String
// #Big_O_Time_O(n)_Space_O(1) #2024_01_11_Time_143_ms_(94.32%)_Space_62.9_MB_(24.95%)

public class Solution {
    private void Reverse(int[] nums, int l, int r) {
        while (l <= r) {
            int temp = nums[l];
            nums[l] = nums[r];
            nums[r] = temp;
            l++;
            r--;
        }
    }

    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        int t = n - (k % n);
        Reverse(nums, 0, t - 1);
        Reverse(nums, t, n - 1);
        Reverse(nums, 0, n - 1);
    }
}
}
