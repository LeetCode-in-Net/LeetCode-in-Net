namespace LeetCodeNet.G0001_0100.S0009_palindrome_number {

// #Easy #Math #Udemy_Integers #Top_Interview_150_Math
// #2023_12_22_Time_42_ms_(34.61%)_Space_31_MB_(36.04%)

public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) {
            return false;
        }
        int rev = 0;
        int localX = x;
        while (localX > 0) {
            rev *= 10;
            rev += localX % 10;
            localX /= 10;
        }
        return rev == x;
    }
}
}
