namespace LeetCodeNet.G0001_0100.S0076_minimum_window_substring {

// #Hard #Top_100_Liked_Questions #Top_Interview_Questions #String #Hash_Table #Sliding_Window
// #Level_2_Day_14_Sliding_Window/Two_Pointer #Top_Interview_150_Sliding_Window
// #Big_O_Time_O(s.length())_Space_O(1) #2024_01_05_Time_56_ms_(98.72%)_Space_42.6_MB_(42.02%)

public class Solution {
    public string MinWindow(string s, string t) {
        int[] map = new int[128];
        foreach (char c in t) {
            map[c - 'A']++;
        }
        int count = t.Length;
        int begin = 0;
        int end = 0;
        int d = int.MaxValue;
        int head = 0;
        while (end < s.Length) {
            if (map[s[end++] - 'A']-- > 0) {
                count--;
            }
            while (count == 0) {
                if (end - begin < d) {
                    d = end - begin;
                    head = begin;
                }
                if (map[s[begin++] - 'A']++ == 0) {
                    count++;
                }
            }
        }
        return d == int.MaxValue ? "" : s.Substring(head, d);
    }
}
}
