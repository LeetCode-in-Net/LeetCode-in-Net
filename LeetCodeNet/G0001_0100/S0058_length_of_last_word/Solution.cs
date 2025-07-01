namespace LeetCodeNet.G0001_0100.S0058_length_of_last_word {

// #Easy #String #Programming_Skills_II_Day_6 #Udemy_Arrays #Top_Interview_150_Array/String
// #2025_07_01_Time_0_ms_(100.00%)_Space_40.26_MB_(15.20%)

public class Solution {
    public int LengthOfLastWord(string s) {
        int length = 0, i = s.Length - 1;
        while (i >= 0 && s[i] == ' ') i--;
        while (i >= 0 && s[i] != ' ') {
            length++;
            i--;
        }
        return length;
    }
}
}
