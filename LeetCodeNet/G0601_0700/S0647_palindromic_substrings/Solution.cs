namespace LeetCodeNet.G0601_0700.S0647_palindromic_substrings {

// #Medium #Top_100_Liked_Questions #String #Dynamic_Programming #Big_O_Time_O(n^2)_Space_O(n)
// #2024_01_07_Time_48_ms_(92.55%)_Space_37.2_MB_(34.47%)

public class Solution {
    private void Expand(char[] a, int l, int r, int[] res) {
        while (l >= 0 && r < a.Length) {
            if (a[l] != a[r]) {
                return;
            } else {
                res[0]++;
                l--;
                r++;
            }
        }
    }

    public int CountSubstrings(string s) {
        char[] a = s.ToCharArray();
        int[] res = {0};
        for (int i = 0; i < a.Length; i++) {
            Expand(a, i, i, res);
            Expand(a, i, i + 1, res);
        }
        return res[0];
    }
}
}
