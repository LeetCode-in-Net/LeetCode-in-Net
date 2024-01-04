namespace LeetCodeNet.G0001_0100.S0055_jump_game
{

    // #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Dynamic_Programming #Greedy
    // #Algorithm_II_Day_12_Dynamic_Programming #Dynamic_Programming_I_Day_4 #Udemy_Arrays
    // #Big_O_Time_O(n)_Space_O(1) #2024_01_04_Time_189_ms_(38.02%)_Space_61.6_MB_(81.87%)

    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            var accumulatedJumps = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (i > accumulatedJumps)
                {
                    return false;
                }
                if (accumulatedJumps >= nums.Length - 1)
                {
                    return true;
                }
                accumulatedJumps = Math.Max(accumulatedJumps, i + nums[i]);
            }
            return false;
        }
    }
}
