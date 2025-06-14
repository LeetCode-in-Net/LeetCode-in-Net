namespace LeetCodeNet.G0101_0200.S0128_longest_consecutive_sequence {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Hash_Table #Union_Find
// #Top_Interview_150_Hashmap #Big_O_Time_O(N_log_N)_Space_O(1)
// #2025_06_14_Time_16_ms_(100.00%)_Space_75.12_MB_(14.84%)

public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, int> mapToHighest = new(nums.Length);
        int best = 0;
        for (int i = 0; i < nums.Length; i++) {
            int rangeLow = 0;
            int rangeHigh = 0;
            if (mapToHighest.ContainsKey(nums[i])) {
                continue;
            }
            if (mapToHighest.TryGetValue(nums[i]-1, out var downCount)) {
                rangeLow = downCount;
            }
            if (mapToHighest.TryGetValue(nums[i]+1, out var upCount)) {
                rangeHigh = upCount;
            }
            int thisSum = rangeLow + rangeHigh + 1;
            mapToHighest[nums[i] - rangeLow] = thisSum;
            mapToHighest[nums[i] + rangeHigh] = thisSum;
            if (rangeLow != 0 && rangeHigh != 0) {
                mapToHighest[nums[i]] = 1;
            }
            best = Math.Max(thisSum, best);
        }
        return best;
    }
}
}
