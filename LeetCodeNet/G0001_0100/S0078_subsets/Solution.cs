namespace LeetCodeNet.G0001_0100.S0078_subsets {

    // #Medium #Backtracking #Algorithm_I_Day_11_Recursion_Backtracking
    // #2024_01_05_Time_373_ms_(25.22%)_Space_140.1_MB_(85.34%)

    public class Solution {
        public IList<IList<int>> Combine(int n, int k) {
            var result = new List<IList<int>>();
            Backtrack(result, new HashSet<int>(), 1, n, k);
            return result;
        }

        private void Backtrack(IList<IList<int>> result, HashSet<int> hashSet, int startIndex, int endIndex, int remainingPositions) {
            if (remainingPositions == 0) {
                result.Add(hashSet.ToList());
                return;
            }

            var lastPossibleStartIndex = endIndex - remainingPositions + 1;
            for (var i = startIndex; i <= lastPossibleStartIndex; i++) {
                if (hashSet.Contains(i))
                    continue;

                hashSet.Add(i);
                Backtrack(result, hashSet, i + 1, endIndex, remainingPositions - 1);
                hashSet.Remove(i);
            }
        }
    }
}
