namespace LeetCodeNet.G0001_0100.S0046_permutations {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Backtracking
// #Algorithm_I_Day_11_Recursion_Backtracking #Level_2_Day_20_Brute_Force/Backtracking
// #Udemy_Backtracking/Recursion #Big_O_Time_O(n*n!)_Space_O(n+n!)
// #2023_12_28_Time_148_ms_(5.56%)_Space_45.8_MB_(8.50%)

using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return new List<IList<int>>();
        }
        IList<IList<int>> finalResult = new List<IList<int>>();
        PermuteRecur(nums, finalResult, new List<int>(), new bool[nums.Length]);
        return finalResult;
    }

    private void PermuteRecur(
            int[] nums, IList<IList<int>> finalResult, List<int> currResult, bool[] used) {
        if (currResult.Count == nums.Length) {
            finalResult.Add(new List<int>(currResult));
            return;
        }
        for (int i = 0; i < nums.Length; i++) {
            if (used[i]) {
                continue;
            }
            currResult.Add(nums[i]);
            used[i] = true;
            PermuteRecur(nums, finalResult, currResult, used);
            used[i] = false;
            currResult.RemoveAt(currResult.Count - 1);
        }
    }
}
}
