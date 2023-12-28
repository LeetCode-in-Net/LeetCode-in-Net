namespace LeetCodeNet.G0001_0100.S0032_longest_valid_parentheses {

// #Hard #Top_100_Liked_Questions #String #Dynamic_Programming #Stack #Big_O_Time_O(n)_Space_O(1)
// #2023_12_28_Time_49_ms_(96.18%)_Space_38.5_MB_(13.54%)

public class Solution {
    public int LongestValidParentheses(string s) {
        int max = 0;
        int left = 0;
        int right = 0;
        int n = s.Length;
        char ch;
        for (int i = 0; i < n; i++) {
            ch = s[i];
            if (ch == '(') {
                left++;
            } else {
                right++;
            }
            if (right > left) {
                left = 0;
                right = 0;
            }
            if (left == right) {
                max = Math.Max(max, 2 * right);
            }
        }
        left = 0;
        right = 0;
        for (int i = n - 1; i >= 0; i--) {
            ch = s[i];
            if (ch == '(') {
                left++;
            } else {
                right++;
            }
            if (left > right) {
                left = 0;
                right = 0;
            }
            if (left == right) {
                max = Math.Max(max, 2 * left);
            }
        }
        return max;
    }
}
}
