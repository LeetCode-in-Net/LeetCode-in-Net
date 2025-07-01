namespace LeetCodeNet.G0001_0100.S0050_powx_n {

// #Medium #Top_Interview_Questions #Math #Recursion #Udemy_Integers #Top_Interview_150_Math
// #2025_07_01_Time_0_ms_(100.00%)_Space_29.14_MB_(83.57%)

public class Solution {
    public double MyPow(double x, int n) {
        if (n == 0) return 1.0;
        long N = n;
        if (N < 0) {
            x = 1 / x;
            N = -N;
        }
        double result = 1.0;
        while (N > 0) {
            if ((N & 1) == 1) result *= x;
            x *= x;
            N >>= 1;
        }
        return result;
    }
}
}
