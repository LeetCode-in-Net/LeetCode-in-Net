namespace LeetCodeNet.G0301_0400.S0392_is_subsequence {

// #Easy #String #Dynamic_Programming #Two_Pointers #LeetCode_75_Two_Pointers
// #Dynamic_Programming_I_Day_19 #Level_1_Day_2_String #Udemy_Two_Pointers
// #Top_Interview_150_Two_Pointers #2025_07_18_Time_0_ms_(100.00%)_Space_41.56_MB_(66.80%)

public class Solution {
    public bool IsSubsequence(string s, string t) {
        int i = 0;
        int j = 0;
        int n = t.Length;
        int m = s.Length;
        if (m == 0) {
            return true;
        }
        while (j < n) {
            if (s[i] == t[j]) {
                i++;
                if (i == m) {
                    return true;
                }
            }
            j++;
        }
        return false;
    }
}
}
