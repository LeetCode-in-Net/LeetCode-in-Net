namespace LeetCodeNet.G0001_0100.S0077_combinations {

// #Medium #Backtracking #Algorithm_I_Day_11_Recursion_Backtracking #Top_Interview_150_Backtracking
// #2025_07_04_Time_29_ms_(89.17%)_Space_97.46_MB_(59.96%)

public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        var res = new List<IList<int>>();
        Backtrack(1, n, k, new List<int>(), res);
        return res;
    }
    private void Backtrack(int start, int n, int k, List<int> curr, List<IList<int>> res) {
        if (curr.Count == k) {
            res.Add(new List<int>(curr));
            return;
        }
        for (int i = start; i <= n; i++) {
            curr.Add(i);
            Backtrack(i + 1, n, k, curr, res);
            curr.RemoveAt(curr.Count - 1);
        }
    }
}
}
