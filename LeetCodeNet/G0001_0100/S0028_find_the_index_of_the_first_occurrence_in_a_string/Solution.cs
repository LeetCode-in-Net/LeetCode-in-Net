namespace LeetCodeNet.G0001_0100.S0028_find_the_index_of_the_first_occurrence_in_a_string {

// #Easy #Top_Interview_Questions #String #Two_Pointers #String_Matching
// #Programming_Skills_II_Day_1 #Top_Interview_150_Array/String
// #2025_06_30_Time_0_ms_(100.00%)_Space_39.28_MB_(63.22%)

public class Solution {
    public int StrStr(string haystack, string needle) {
        if (string.IsNullOrEmpty(needle)) {
            return 0;
        }
        if (haystack.Length < needle.Length) {
            return -1;
        }
        for (int i = 0; i <= haystack.Length - needle.Length; i++) {
            if (haystack.Substring(i, needle.Length) == needle) {
                return i;
            }
        }
        return -1;
    }
}
}
