namespace LeetCodeNet.G0201_0300.S0219_contains_duplicate_ii {

// #Easy #Array #Hash_Table #Sliding_Window #Top_Interview_150_Hashmap
// #2025_07_14_Time_12_ms_(98.14%)_Space_69.92_MB_(59.27%)

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        int len = nums.Length;
        for (int i = 0; i < len; i++) {
            if (map.TryGetValue(nums[i], out int index) && Math.Abs(index - i) <= k) {
                return true;
            }
            map[nums[i]] = i;
        }
        return false;
    }
}
}
