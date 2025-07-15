namespace LeetCodeNet.G0201_0300.S0242_valid_anagram {

// #Easy #String #Hash_Table #Sorting #Data_Structure_I_Day_6_String
// #Programming_Skills_I_Day_11_Containers_and_Libraries #Udemy_Strings #Top_Interview_150_Hashmap
// #2025_07_15_Time_0_ms_(100.00%)_Space_43.94_MB_(45.52%)

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        int[] charFreqMap = new int[26];
        foreach (char c in s) {
            charFreqMap[c - 'a']++;
        }
        foreach (char c in t) {
            if (charFreqMap[c - 'a'] == 0) {
                return false;
            }
            charFreqMap[c - 'a']--;
        }
        return true;
    }
}
}
