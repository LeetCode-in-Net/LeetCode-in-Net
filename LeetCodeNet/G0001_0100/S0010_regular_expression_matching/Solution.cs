namespace LeetCodeNet.G0001_0100.S0010_regular_expression_matching {

// #Hard #Top_Interview_Questions #String #Dynamic_Programming #Recursion #Udemy_Dynamic_Programming
// #Big_O_Time_O(m*n)_Space_O(m*n) #2025_06_12_Time_1_ms_(99.81%)_Space_42.56_MB_(59.73%)

public class Solution {
    private bool?[,] cache;

    public bool IsMatch(string s, string p) {
        cache = new bool?[s.Length + 1, p.Length + 1];
        return IsMatch(s, p, 0, 0);
    }

    private bool IsMatch(string s, string p, int i, int j) {
        if (j == p.Length) {
            return i == s.Length;
        }
        bool result;
        if (cache[i, j] != null) {
            return cache[i, j].Value;
        }
        bool firstMatch = i < s.Length && (s[i] == p[j] || p[j] == '.');
        if ((j + 1) < p.Length && p[j + 1] == '*') {
            result = (firstMatch && IsMatch(s, p, i + 1, j)) || IsMatch(s, p, i, j + 2);
        } else {
            result = firstMatch && IsMatch(s, p, i + 1, j + 1);
        }
        cache[i, j] = result;
        return result;
    }
}
}
