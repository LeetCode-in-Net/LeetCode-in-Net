namespace LeetCodeNet.G0001_0100.S0049_group_anagrams {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #String #Hash_Table #Sorting
// #Data_Structure_II_Day_8_String #Programming_Skills_II_Day_11 #Udemy_Strings
// #Top_Interview_150_Hashmap #Big_O_Time_O(n*k_log_k)_Space_O(n)
// #2024_01_04_Time_145_ms_(96.20%)_Space_80.2_MB_(38.80%)

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, IList<string>>();
        // allocate memory only once and reuse it to sort the chars of each s in strs.
        var buffer = new char[10000];
        var bufferSpan = new Span<char>(buffer);
        foreach (var s in strs) {
            s.CopyTo(bufferSpan);
            Array.Sort(buffer, 0, s.Length);
            var key = new string(buffer, 0, s.Length);
            if (!map.TryGetValue(key, out var value)) {
                map[key] = value = new List<string>();
            }
            value.Add(s);
        }
        return map.Values.Cast<IList<string>>().ToList();
    }
}
}
