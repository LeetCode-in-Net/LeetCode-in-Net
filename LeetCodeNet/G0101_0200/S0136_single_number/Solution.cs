namespace LeetCodeNet.G0101_0200.S0136_single_number {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #Array #Bit_Manipulation
// #LeetCode_75_Bit_Manipulation #Data_Structure_II_Day_1_Array
// #Algorithm_I_Day_14_Bit_Manipulation #Udemy_Integers #Top_Interview_150_Bit_Manipulation
// #Big_O_Time_O(N)_Space_O(1) #2025_06_14_Time_0_ms_(100.00%)_Space_46.90_MB_(50.83%)

public class Solution {
    public int SingleNumber(int[] nums) {
        int res = 0;
        foreach (int num in nums) {
            res ^= num;
        }
        return res;
    }
}
}
