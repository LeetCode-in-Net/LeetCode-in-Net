namespace LeetCodeNet.G0201_0300.S0283_move_zeroes {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #Array #Two_Pointers
// #Algorithm_I_Day_3_Two_Pointers #Programming_Skills_I_Day_6_Array #Udemy_Arrays
// #Big_O_Time_O(n)_Space_O(1) #2024_01_07_Time_133_ms_(96.30%)_Space_57_MB_(17.07%)

public class Solution {
    public void MoveZeroes(int[] nums) {
        int firstZero = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                Swap(firstZero, i, nums);
                firstZero++;
            }
        }
    }

    private void Swap(int index1, int index2, int[] numbers) {
        int val2 = numbers[index2];
        numbers[index2] = numbers[index1];
        numbers[index1] = val2;
    }
}
}
