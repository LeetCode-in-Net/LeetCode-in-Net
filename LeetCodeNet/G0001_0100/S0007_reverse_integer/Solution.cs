namespace LeetCodeNet.G0001_0100.S0007_reverse_integer {

// #Medium #Top_Interview_Questions #Math #Udemy_Integers
// #2023_12_22_Time_23_ms_(59.02%)_Space_26.3_MB_(99.19%)

public class Solution {
    public int Reverse(int x) {
        long rev = 0;
        while (x != 0) {
            rev = (rev * 10) + (x % 10);
            x /= 10;
        }
        if (rev > int.MaxValue || rev < int.MinValue) {
            return 0;
        }
        return (int) rev;
    }
}
}
