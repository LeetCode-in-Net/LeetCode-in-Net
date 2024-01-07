namespace LeetCodeNet.G0201_0300.S0239_sliding_window_maximum {

// #Hard #Top_100_Liked_Questions #Top_Interview_Questions #Array #Heap_Priority_Queue
// #Sliding_Window #Queue #Monotonic_Queue #Udemy_Arrays #Big_O_Time_O(n*k)_Space_O(n+k)
// #2024_01_07_Time_493_ms_(46.05%)_Space_133.5_MB_(14.15%)

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
