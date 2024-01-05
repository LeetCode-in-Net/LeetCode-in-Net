namespace LeetCodeNet.G0001_0100.S0076_minimum_window_substring {

// #Hard #Top_100_Liked_Questions #Top_Interview_Questions #String #Hash_Table #Sliding_Window
// #Level_2_Day_14_Sliding_Window/Two_Pointer #Big_O_Time_O(s.length())_Space_O(1)
// #2024_01_05_Time_66_ms_(93.87%)_Space_43.1_MB_(33.62%)

public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(s) || s.Length < t.Length) {
            return "";
        }
        IDictionary<char, int> map = new Dictionary<char, int>(t.Length);
        for (int index = 0; index < t.Length; index++) {
            char c = t[index];
            if (!map.ContainsKey(c)) {
                map.Add(c, 1);
            }
            else {
                map[c]++;
            }
        }
        IDictionary<char, int> foundMap = new Dictionary<char, int>(t.Length);
        int matchRequired = map.Keys.Count;
        int matched = 0;
        int minWindowStart = -1;
        int minWindowEnd = -1;
        int minWindow = Int32.MaxValue;
        int start = 0;
        int end = 0;
        while (start <= end && end < s.Length) {
            char c = s[end];
            if (!map.ContainsKey(c)) {
                end++;
                continue;
            }

            if (!foundMap.ContainsKey(c)) {
                foundMap.Add(c, 1);
            }
            else {
                foundMap[c]++;
            }
            if (foundMap[c] == map[c]) {
                matched++;
            }
            while (matched == matchRequired && start <= end) {
                if ((end - start + 1) < minWindow) {
                    minWindowStart = start;
                    minWindowEnd = end;
                    minWindow = end - start + 1;
                }

                var startChar = s[start];
                if (foundMap.ContainsKey(startChar)) {
                    foundMap[startChar]--;
                    if (foundMap[startChar] < map[startChar]) {
                        matched--;
                    }
                }
                start++;
            }
            end++;
        }
        return minWindow < Int32.MaxValue ? s.Substring(minWindowStart, minWindowEnd - minWindowStart + 1) : "";
    }
}
}
