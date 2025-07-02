namespace LeetCodeNet.G0001_0100.S0066_plus_one {

// #Easy #Top_Interview_Questions #Array #Math #Programming_Skills_II_Day_3 #Udemy_Arrays
// #Top_Interview_150_Math #2025_07_02_Time_0_ms_(100.00%)_Space_46.64_MB_(51.35%)

public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        int[] res = new int[digits.Length + 1];
        res[0] = 1;
        return res;
    }
}
}
