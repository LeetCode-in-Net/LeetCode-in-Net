namespace LeetCodeNet.G0301_0400.S0383_ransom_note {

// #Easy #String #Hash_Table #Counting #Data_Structure_I_Day_6_String #Top_Interview_150_Hashmap
// #2025_07_16_Time_1_ms_(98.72%)_Space_46.21_MB_(69.80%)

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] count = new int[26];
        foreach (char c in magazine) count[c - 'a']++;
        foreach (char c in ransomNote) {
            if (--count[c - 'a'] < 0) return false;
        }
        return true;
    }
}
}
