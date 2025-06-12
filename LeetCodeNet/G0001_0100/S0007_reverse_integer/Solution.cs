namespace LeetCodeNet.G0001_0100.S0007_reverse_integer {

// #Medium #Top_Interview_Questions #Math #Udemy_Integers
// #2025_06_12_Time_14_ms_(99.26%)_Space_29.02_MB_(67.56%)

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
