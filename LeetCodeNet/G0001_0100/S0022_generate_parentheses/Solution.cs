namespace LeetCodeNet.G0001_0100.S0022_generate_parentheses {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #String #Dynamic_Programming
// #Backtracking #Algorithm_II_Day_11_Recursion_Backtracking #Udemy_Backtracking/Recursion
// #Big_O_Time_O(2^n)_Space_O(n) #2023_12_26_Time_81_ms_(99.57%)_Space_48.3_MB_(12.19%)

using System.Collections.Generic;
using System.Text;

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        StringBuilder sb = new StringBuilder();
        List<string> ans = new List<string>();
        return Generate(sb, ans, n, n);
    }

    private IList<string> Generate(StringBuilder sb, List<string> str, int open, int close) {
        if (open == 0 && close == 0) {
            str.Add(sb.ToString());
            return str;
        }
        if (open > 0) {
            sb.Append('(');
            Generate(sb, str, open - 1, close);
            sb.Length--; // Equivalent to deleting the last character in StringBuilder
        }
        if (close > 0 && open < close) {
            sb.Append(')');
            Generate(sb, str, open, close - 1);
            sb.Length--; // Equivalent to deleting the last character in StringBuilder
        }
        return str;
    }
}
}
