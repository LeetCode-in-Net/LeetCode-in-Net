namespace LeetCodeNet.G0301_0400.S0373_find_k_pairs_with_smallest_sums {

// #Medium #Array #Heap_Priority_Queue #Top_Interview_150_Heap
// #2025_07_16_Time_52_ms_(73.33%)_Space_92.81_MB_(30.00%)

using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var result = new List<IList<int>>();
        if (nums1.Length == 0 || nums2.Length == 0 || k == 0) {
            return result;
        }
        var pq = new PriorityQueue<(int i, int j), int>();
        // Initialize with pairs from nums1[0] with each element in nums2 up to `k`
        for (int j = 0; j < nums2.Length && j < k; j++) {
            pq.Enqueue((0, j), nums1[0] + nums2[j]);
        }
        while (k-- > 0 && pq.Count > 0) {
            var (i, j) = pq.Dequeue();
            result.Add(new List<int> { nums1[i], nums2[j] });
            // If there's another pair with the next element in nums1, add it
            if (i + 1 < nums1.Length) {
                pq.Enqueue((i + 1, j), nums1[i + 1] + nums2[j]);
            }
        }
        return result;
    }
}
}
