namespace LeetCodeNet.G0001_0100.S0055_jump_game {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Dynamic_Programming #Greedy
// #Algorithm_II_Day_12_Dynamic_Programming #Dynamic_Programming_I_Day_4 #Udemy_Arrays
// #Top_Interview_150_Array/String #Big_O_Time_O(n)_Space_O(1)
// #2025_06_13_Time_1_ms_(99.82%)_Space_61.18_MB_(41.64%)

public class Solution {
    public bool CanJump(int[] nums) {
        var accumulatedJumps = 0;
        for (var i = 0; i < nums.Length; i++) {
            if (i > accumulatedJumps) {
                return false;
            }
            if (accumulatedJumps >= nums.Length - 1) {
                return true;
            }
            accumulatedJumps = Math.Max(accumulatedJumps, i + nums[i]);
        }
        return false;
    }
}
}
