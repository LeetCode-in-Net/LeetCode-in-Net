namespace LeetCodeNet.G0201_0300.S0201_bitwise_and_of_numbers_range {

// #Medium #Bit_Manipulation #Algorithm_II_Day_19_Bit_Manipulation
// #Top_Interview_150_Bit_Manipulation #2025_07_13_Time_1_ms_(96.12%)_Space_29.94_MB_(51.46%)

public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        var shift = 0;
        for (; left != right; left >>= 1, right >>= 1, shift++) { 

        }
        return left << shift;
    }
}
}
