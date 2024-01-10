namespace LeetCodeNet.G0201_0300.S0215_kth_largest_element_in_an_array {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Sorting #Heap_Priority_Queue
// #Divide_and_Conquer #Quickselect #Data_Structure_II_Day_20_Heap_Priority_Queue
// #Big_O_Time_O(n*log(n))_Space_O(log(n)) #2024_01_10_Time_252_ms_(46.14%)_Space_55_MB_(26.22%)

using System;

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int n = nums.Length;
        Array.Sort(nums);
        return nums[n - k];
    }
}
}
