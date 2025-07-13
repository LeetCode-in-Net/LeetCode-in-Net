namespace LeetCodeNet.G0101_0200.S0191_number_of_1_bits {

    // #Easy #Top_Interview_Questions #Bit_Manipulation #Algorithm_I_Day_13_Bit_Manipulation
    // #Programming_Skills_I_Day_2_Operator #Udemy_Bit_Manipulation #Top_Interview_150_Bit_Manipulation
    // #2025_07_13_Time_0_ms_(100.00%)_Space_28.91_MB_(71.79%)

    public class Solution {
    public int HammingWeight(int n) {
        int sum = 0;
        bool flag = false;
        if ((int)n < 0) {
            flag = true;
            n = n - int.MinValue;
        }
        while (n > 0) {
            int k = (int)(n % 2);
            sum += k;
            n /= 2;
        }
        return flag ? sum + 1 : sum;
    }
}
}
