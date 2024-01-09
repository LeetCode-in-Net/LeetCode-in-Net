namespace LeetCodeNet.G0101_0200.S0139_word_break {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #String #Hash_Table
// #Dynamic_Programming #Trie #Memoization #Algorithm_II_Day_15_Dynamic_Programming
// #Dynamic_Programming_I_Day_9 #Udemy_Dynamic_Programming #Big_O_Time_O(M+max*N)_Space_O(M+N+max)
// #2024_01_09_Time_64_ms_(98.44%)_Space_49.2_MB_(10.24%)

public class Solution {
    private Dictionary<string, bool> visited = new();
    private HashSet<string>? set;

    public bool WordBreak(string s, IList<string> wordDict) {
        set = new HashSet<string>(wordDict);
        return CheckWordBreak(s);
    }

    public bool CheckWordBreak(string s) {
        if (visited.ContainsKey(s)) {
            return visited[s];
        }
        if (set.Contains(s)) {
            return true;
        }
        for (int i=0; i<s.Length; i++) {
             if (set.Contains(s.Substring(0, i)) && CheckWordBreak(s.Substring(i))) {
                 visited[s]= true;
                 return true;
             }
        }
       visited[s] = false;
       return false;
    }
}   
}
