namespace LeetCodeNet.G0301_0400.S0394_decode_string {

// #Medium #Top_100_Liked_Questions #String #Stack #Recursion #LeetCode_75_Stack
// #Level_1_Day_14_Stack #Udemy_Strings #Big_O_Time_O(n)_Space_O(n)
// #2024_01_07_Time_44_ms_(99.55%)_Space_38.2_MB_(26.91%)

using System.Text;

public class Solution {
    private int i = 0;

    public string DecodeString(string s) {
        int count = 0;
        var sb = new StringBuilder();
        while (i < s.Length) {
            char c = s[i];
            i++;
            if (char.IsLetter(c)) {
                sb.Append(c);
            } else if (char.IsDigit(c)) {
                count = count * 10 + (int) char.GetNumericValue(c);
            } else if (c == ']') {
                break;
            } else if (c == '[') {
                // sub problem
                string repeat = DecodeString(s);
                while (count > 0) {
                    sb.Append(repeat);
                    count--;
                }
            }
        }
        return sb.ToString();
    }
}
}
