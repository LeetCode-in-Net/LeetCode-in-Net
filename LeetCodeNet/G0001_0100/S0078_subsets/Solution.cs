namespace LeetCodeNet.G0001_0100.S0078_subsets {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Bit_Manipulation #Backtracking
// #Algorithm_II_Day_9_Recursion_Backtracking #Udemy_Backtracking/Recursion
// #Big_O_Time_O(2^n)_Space_O(n*2^n) #2024_01_05_Time_101_ms_(94.29%)_Space_45.7_MB_(8.93%)

using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        Solve(nums, new List<int>(), res, 0);
        return res;
    }

    private void Solve(int[] nums, List<int> temp, IList<IList<int>> res, int start) {
        res.Add(new List<int>(temp));
        for (int i = start; i < nums.Length; i++) {
            temp.Add(nums[i]);
            Solve(nums, temp, res, i + 1);
            temp.RemoveAt(temp.Count - 1);
        }
    }
}
}
