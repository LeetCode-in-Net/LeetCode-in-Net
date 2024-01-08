namespace LeetCodeNet.G0001_0100.S0096_unique_binary_search_trees {

    // #Medium #Top_100_Liked_Questions #Dynamic_Programming #Math #Tree #Binary_Tree
    // #Binary_Search_Tree #Dynamic_Programming_I_Day_11 #Big_O_Time_O(n)_Space_O(1)
    // #2024_01_08_Time_13_ms_(98.48%)_Space_26.2_MB_(88.64%)

    public class Solution {
        public int NumTrees(int n) {
            long result = 1;
            for (int i = 0; i < n; i++) {
                result *= 2L * n - i;
                result /= i + 1;
            }
            result /= n + 1;
            return (int)result;
        }
    }

}
