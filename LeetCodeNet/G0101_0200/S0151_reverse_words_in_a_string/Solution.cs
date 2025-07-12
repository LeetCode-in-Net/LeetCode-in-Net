namespace LeetCodeNet.G0101_0200.S0151_reverse_words_in_a_string {

// #Medium #String #Two_Pointers #LeetCode_75_Array/String #Udemy_Strings
// #Top_Interview_150_Array/String #2025_07_12_Time_2_ms_(67.44%)_Space_41.52_MB_(95.70%)

using System.Text;

public class Solution {
    public string ReverseWords(string s) {
        var sb = new StringBuilder();
        int i = s.Length - 1;
        while (i >= 0) {
            if (s[i] == ' ') {
                i--;
                continue;
            }
            int start = s.LastIndexOf(' ', i);
            sb.Append(' ');
            sb.Append(s, start + 1, i - start);
            i = start - 1;
        }
        if (sb.Length > 0) {
            sb.Remove(0, 1);
        }
        return sb.ToString();
    }
}
}
