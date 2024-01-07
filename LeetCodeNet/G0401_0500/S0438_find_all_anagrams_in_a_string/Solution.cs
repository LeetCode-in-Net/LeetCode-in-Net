namespace LeetCodeNet.G0401_0500.S0438_find_all_anagrams_in_a_string {

// #Medium #Top_100_Liked_Questions #String #Hash_Table #Sliding_Window
// #Algorithm_II_Day_5_Sliding_Window #Programming_Skills_II_Day_12
// #Level_1_Day_12_Sliding_Window/Two_Pointer #Big_O_Time_O(n+m)_Space_O(1)
// #2024_01_07_Time_103_ms_(97.89%)_Space_50.2_MB_(32.49%)

using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        int[] map = new int[26];
        for (int index = 0; index < p.Length; ++index) {
            map[p[index] - 'a']++;
        }
        IList<int> res = new List<int>();
        int i = 0;
        int j = 0;
        while (i < s.Length) {
            int idx = s[i] - 'a';
            // add the new character
            map[idx]--;
            // if the length is greater than windows length, pop the left charcater in the window
            if (i >= p.Length) {
                map[s[j++] - 'a']++;
            }
            bool finish = true;
            for (int k = 0; k < 26; k++) {
                // if it is not an anagram of string p
                if (map[k] != 0) {
                    finish = false;
                    break;
                }
            }
            if (i >= p.Length - 1 && finish) {
                res.Add(j);
            }
            i++;
        }
        return res;
    }
}
}
