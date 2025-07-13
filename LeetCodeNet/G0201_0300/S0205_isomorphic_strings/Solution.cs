namespace LeetCodeNet.G0201_0300.S0205_isomorphic_strings {

// #Easy #String #Hash_Table #Level_1_Day_2_String #Top_Interview_150_Hashmap
// #2025_07_13_Time_2_ms_(90.78%)_Space_44.12_MB_(18.33%)

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        int[] map = new int[128];
        char[] str = s.ToCharArray();
        char[] tar = t.ToCharArray();
        int n = str.Length;
        for (int i = 0; i < n; i++) {
            if (map[tar[i]] == 0) {
                if (Search(map, str[i], tar[i]) != -1) {
                    return false;
                }
                map[tar[i]] = str[i];
            } else {
                if (map[tar[i]] != str[i]) {
                    return false;
                }
            }
        }
        return true;
    }

    private int Search(int[] map, int tar, int skip) {
        for (int i = 0; i < 128; i++) {
            if (i == skip) {
                continue;
            }
            if (map[i] != 0 && map[i] == tar) {
                return i;
            }
        }
        return -1;
    }
}
}
