namespace LeetCodeNet.G0201_0300.S0215_kth_largest_element_in_an_array {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Sorting #Heap_Priority_Queue
// #Divide_and_Conquer #Quickselect #LeetCode_75_Heap/Priority_Queue
// #Data_Structure_II_Day_20_Heap_Priority_Queue #Top_Interview_150_Heap
// #Big_O_Time_O(n*log(n))_Space_O(log(n)) #2025_06_14_Time_85_ms_(88.50%)_Space_59.24_MB_(25.42%)

using System;

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int n = nums.Length;
        Array.Sort(nums);
        return nums[n - k];
    }
}
}
