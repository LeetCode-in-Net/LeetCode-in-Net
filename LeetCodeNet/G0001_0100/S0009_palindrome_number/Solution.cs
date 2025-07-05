namespace LeetCodeNet.G0001_0100.S0009_palindrome_number {

// #Easy #Math #Udemy_Integers #Top_Interview_150_Math #Big_O_Time_O(log10(x))_Space_O(1)
// #2025_06_12_Time_1_ms_(99.90%)_Space_34.74_MB_(67.61%)

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
