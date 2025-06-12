namespace LeetCodeNet.G0001_0100.S0005_longest_palindromic_substring {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #String #Dynamic_Programming
// #Data_Structure_II_Day_9_String #Algorithm_II_Day_14_Dynamic_Programming
// #Dynamic_Programming_I_Day_17 #Udemy_Strings #Top_Interview_150_Multidimensional_DP
// #Big_O_Time_O(n)_Space_O(n) #2025_06_12_Time_7_ms_(95.82%)_Space_41.34_MB_(65.26%)

public class Solution {
    public string LongestPalindrome(string s) {
        if (s.Length == 1) return s;
        int res = 0;
        int l = 0;
        int r = 0;
        int len = s.Length;
        for (int i = 0; i < len; i ++) {
            for (int diff = 1; i - diff + 1 >= 0 && i + diff < len; diff ++) {
                if (s[i - diff + 1] != s[i + diff]) break;
                else if (res < diff * 2) {
                    res = diff * 2;
                    l = i - diff + 1;
                    r = i + diff;
                }
            }
        }
        for (int i = 0; i < len; i ++) {
            for (int diff = 1; i - diff >= 0 && i + diff < len; diff ++) {
                if (s[i - diff] != s[i + diff]) break;
                else if (res < diff * 2 + 1) {
                    res = diff * 2 + 1;
                    l = i - diff;
                    r = i + diff;
                }
            }
        }
        return s.Substring(l, r - l + 1);
    }
}
}
