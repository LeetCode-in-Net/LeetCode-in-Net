namespace LeetCodeNet.G0201_0300.S0290_word_pattern {

// #Easy #String #Hash_Table #Data_Structure_II_Day_7_String #Top_Interview_150_Hashmap
// #2025_07_16_Time_0_ms_(100.00%)_Space_40.84_MB_(71.08%)

public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<char, string> dict = new();
        string[] str = s.Split(" ");
        if (pattern.Length != str.Length) {
            return false;
        }
        for (int i = 0; i < pattern.Length; i++) {
            if (!dict.ContainsKey(pattern[i]) && !dict.ContainsValue(str[i])) {
                dict.Add(pattern[i], str[i]);
            }
            if (!dict.ContainsKey(pattern[i]) || !str[i].Equals(dict[pattern[i]])) {
                return false;
            }
        }
        return true;
    }
}
}
