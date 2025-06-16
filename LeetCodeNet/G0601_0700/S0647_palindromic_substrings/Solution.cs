namespace LeetCodeNet.G0601_0700.S0647_palindromic_substrings {

// #Medium #String #Dynamic_Programming #Big_O_Time_O(n^2)_Space_O(n)
// #2025_06_16_Time_10_ms_(72.48%)_Space_38.84_MB_(83.72%)

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
