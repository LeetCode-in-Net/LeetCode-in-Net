namespace LeetCodeNet.G0301_0400.S0347_top_k_frequent_elements {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Hash_Table #Sorting
// #Heap_Priority_Queue #Counting #Divide_and_Conquer #Quickselect #Bucket_Sort
// #Data_Structure_II_Day_20_Heap_Priority_Queue #Big_O_Time_O(n*log(n))_Space_O(k)
// #2024_01_07_Time_125_ms_(95.29%)_Space_50.6_MB_(12.11%)

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if (k == nums.Length) {
            return nums;
        } 
        //1. build dictionary
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i=0; i < nums.Length; i++) {
            if (!dict.ContainsKey(nums[i])) {
                dict.Add(nums[i],0);
            }  
            dict[nums[i]] +=1;
        }
        //2. build priority queue based on highest to lowest frequency
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach (var key in dict.Keys) {
            pq.Enqueue(key, dict[key]);
        }
        // 3. return top k elements from Priority Queue
        var result = new int[k];
        for (var i = 0; i < k; i++) {
            result[i] = pq.Dequeue();
        }
        return result;
    }
}
}
