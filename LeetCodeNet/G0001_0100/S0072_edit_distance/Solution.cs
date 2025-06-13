namespace LeetCodeNet.G0001_0100.S0072_edit_distance {

// #Medium #Top_100_Liked_Questions #String #Dynamic_Programming #LeetCode_75_DP/Multidimensional
// #Algorithm_II_Day_18_Dynamic_Programming #Dynamic_Programming_I_Day_19
// #Udemy_Dynamic_Programming #Top_Interview_150_Multidimensional_DP #Big_O_Time_O(n^2)_Space_O(n2)
// #2025_06_13_Time_4_ms_(89.69%)_Space_46.23_MB_(62.11%)

public class Solution {
    public int MinDistance(string word1, string word2) {
        var map = new int[word1.Length + 1, word2.Length + 1];
        for (int i = 0; i <= word1.Length; i++) {
            map[i, 0] = i;
        }
        for (int i = 0; i <= word2.Length; i++) {
            map[0, i] = i;
        }
        for (int i = 1; i <= word1.Length; i++) {
            for (var j = 1; j <= word2.Length; j++) {
                var add = word1[i - 1] == word2[j - 1] ? 0 : 1;
                var min = Math.Min(map[i - 1, j] + 1, map[i, j - 1] + 1);
                map[i, j] = Math.Min(min, map[i - 1, j - 1] + add);
            }
        }
        return map[word1.Length, word2.Length];
    }
}
}
