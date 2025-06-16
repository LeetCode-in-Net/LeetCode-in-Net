namespace LeetCodeNet.G0201_0300.S0239_sliding_window_maximum {

// #Hard #Top_100_Liked_Questions #Array #Heap_Priority_Queue #Sliding_Window #Queue
// #Monotonic_Queue #Udemy_Arrays #Big_O_Time_O(n*k)_Space_O(n+k)
// #2025_06_16_Time_32_ms_(94.92%)_Space_83.28_MB_(70.68%)

using System;
using System.Collections.Generic;

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        int[] res = new int[n - k + 1];
        int x = 0;
        LinkedList<int> dq = new LinkedList<int>();
        int i = 0;
        int j = 0;
        while (j < nums.Length) {
            while (dq.Count != 0 && dq.Last.Value < nums[j]) {
                dq.RemoveLast();
            }
            dq.AddLast(nums[j]);
            if (j - i + 1 == k) {
                res[x] = dq.First.Value;
                ++x;
                if (dq.First.Value == nums[i]) {
                    dq.RemoveFirst();
                }
                ++i;
            }
            ++j;
        }
        return res;
    }
}
}
