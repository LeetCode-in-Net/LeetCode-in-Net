namespace LeetCodeNet.G0101_0200.S0137_single_number_ii {

// #Medium #Array #Bit_Manipulation #Top_Interview_150_Bit_Manipulation
// #2025_07_12_Time_0_ms_(100.00%)_Space_43.58_MB_(81.90%)

public class Solution {
    public int SingleNumber(int[] nums) {
        int ones = 0;
        int twos = 0;
        foreach (int num in nums) {
            ones = (ones ^ num) & (~twos);
            twos = (twos ^ num) & (~ones);
        }
        return ones;
    }
}
}
