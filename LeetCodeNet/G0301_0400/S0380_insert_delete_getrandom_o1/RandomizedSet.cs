namespace LeetCodeNet.G0301_0400.S0380_insert_delete_getrandom_o1 {

// #Medium #Array #Hash_Table #Math #Design #Randomized #Programming_Skills_II_Day_20
// #Top_Interview_150_Array/String #2025_07_16_Time_10_ms_(100.00%)_Space_118.29_MB_(51.31%)

using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public class RandomizedSet {
    private List<int> nums;
    private Dictionary<int, int> dict;
    private RandomNumberGenerator rng;
    public RandomizedSet() {
        nums = new List<int>();
        dict = new Dictionary<int, int>();
        rng = RandomNumberGenerator.Create();
    }
    public bool Insert(int val) {
        if (dict.ContainsKey(val)) return false;
        dict[val] = nums.Count;
        nums.Add(val);
        return true;
    }
    public bool Remove(int val) {
        if (!dict.ContainsKey(val)) return false;
        int idx = dict[val];
        int last = nums[nums.Count - 1];
        nums[idx] = last;
        dict[last] = idx;
        nums.RemoveAt(nums.Count - 1);
        dict.Remove(val);
        return true;
    }
    public int GetRandom() {
        if (nums.Count == 0) throw new InvalidOperationException();
        byte[] bytes = new byte[4];
        int idx;
        do {
            rng.GetBytes(bytes);
            idx = BitConverter.ToInt32(bytes, 0) & int.MaxValue;
            idx %= nums.Count;
        } while (idx < 0 || idx >= nums.Count);
        return nums[idx];
    }
}
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
