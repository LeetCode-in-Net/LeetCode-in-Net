namespace LeetCodeNet.G0101_0200.S0131_palindrome_partitioning {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #String #Dynamic_Programming
// #Backtracking #Big_O_Time_O(N*2^N)_Space_O(2^N*N)
// #2025_06_14_Time_19_ms_(39.67%)_Space_84.16_MB_(63.28%)

public class Solution {
    public IList<IList<string>> Partition(string s) {
        IList<IList<string>> res = new List<IList<string>>();
        Backtracking(res, new List<string>(), s, 0);
        return res;
    }

    private void Backtracking(IList<IList<string>> res, IList<string> currArr, string s, int start) {
        if (start == s.Length) {
            res.Add(new List<string>(currArr));
        }
        for (int end = start; end < s.Length; end++) {
            if (!IsPanlindrome(s, start, end)) {
                continue;
            }
            currArr.Add(s.Substring(start, end - start + 1));
            Backtracking(res, currArr, s, end + 1);
            currArr.RemoveAt(currArr.Count - 1);
        }
    }

    private bool IsPanlindrome(string s, int start, int end) {
        while (start < end && s[start] == s[end]) {
            start++;
            end--;
        }
        return start >= end;
    }
}
}
