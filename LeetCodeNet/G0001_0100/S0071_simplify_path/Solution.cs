namespace LeetCodeNet.G0001_0100.S0071_simplify_path {

// #Medium #String #Stack #Top_Interview_150_Stack
// #2025_07_04_Time_2_ms_(90.87%)_Space_42.38_MB_(89.63%)

public class Solution {
    public string SimplifyPath(string path) {
        var parts = path.Split('/');
        var newParts = new List<string>();
        for (var i = 0; i < parts.Length; i++) {
            if (parts[i] == string.Empty) {
                continue;
            }
            if (parts[i] == ".") {
                continue;
            }
            if (parts[i] == "..") {
                if (newParts.Count > 0)
                    newParts.RemoveAt(newParts.Count - 1);
                continue;
            }
            newParts.Add(parts[i]);
        }
        return $"/{string.Join("/", newParts)}";
    }
}
}
