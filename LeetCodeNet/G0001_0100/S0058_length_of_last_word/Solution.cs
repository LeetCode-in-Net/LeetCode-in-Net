namespace LeetCodeNet.G0001_0100.S0058_length_of_last_word {

// #Easy #String #Programming_Skills_II_Day_6 #Udemy_Arrays #Top_Interview_150_Array/String
// #2025_07_02_Time_0_ms_(100.00%)_Space_40.17_MB_(24.14%)

public class Solution {
    public int LengthOfLastWord(string s) {
        int len = 0;
        for (int i = s.Length - 1; i >= 0; i--) {
            char ch = s[i];
            if (ch == ' ' && len > 0) {
                break;
            } else if (ch != ' ') {
                len++;
            }
        }
        return len;
    }
}
}
