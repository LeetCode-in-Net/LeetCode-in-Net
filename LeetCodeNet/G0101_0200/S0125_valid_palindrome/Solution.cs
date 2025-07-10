namespace LeetCodeNet.G0101_0200.S0125_valid_palindrome {

// #Easy #Top_Interview_Questions #String #Two_Pointers #Udemy_Two_Pointers
// #Top_Interview_150_Two_Pointers #2025_07_10_Time_1_ms_(99.79%)_Space_44.52_MB_(97.65%)

public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;
        bool res = true;
        while (res) {
            while (i < j && IsNotAlphaNumeric(s[i])) {
                i++;
            }
            while (i < j && IsNotAlphaNumeric(s[j])) {
                j--;
            }
            if (i >= j) {
                break;
            }
            char left = UpperToLower(s[i]);
            char right = UpperToLower(s[j]);
            if (left != right) {
                res = false;
            }
            i++;
            j--;
        }
        return res;
    }

    private bool IsNotAlphaNumeric(char c) {
        return (c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && (c < '0' || c > '9');
    }

    private bool IsUpper(char c) {
        return c >= 'A' && c <= 'Z';
    }

    private char UpperToLower(char c) {
        if (IsUpper(c)) {
            c = (char)(c + 32);
        }
        return c;
    }
}
}
