namespace LeetCodeNet.G0101_0200.S0172_factorial_trailing_zeroes {

// #Medium #Top_Interview_Questions #Math #Udemy_Integers #Top_Interview_150_Math
// #2025_07_13_Time_0_ms_(100.00%)_Space_29.27_MB_(31.68%)

public class Solution {
    public int TrailingZeroes(int n) {
        int baseN = 5;
        int count = 0;
        while (n >= baseN) {
            count += n / baseN;
            baseN = baseN * 5;
        }
        return count;
    }
}
}
