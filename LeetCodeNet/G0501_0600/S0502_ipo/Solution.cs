namespace LeetCodeNet.G0501_0600.S0502_ipo {

// #Hard #Array #Sorting #Greedy #Heap_Priority_Queue #Top_Interview_150_Heap
// #2025_07_18_Time_199_ms_(62.82%)_Space_89.82_MB_(10.25%)

using System;
using System.Collections.Generic;

public class Solution {
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {
        // Min-heap for projects based on capital required
        // TElement is int[] {profit, capital}, TPriority is capital (for min-heap)
        // The comparer here compares the TPriority values (which are 'int').
        var minCapital = new PriorityQueue<int[], int>(); // Default comparer for int is min-heap
        // Max-heap for projects based on profit
        // TElement is int[] {profit, capital}, TPriority is profit (for max-heap)
        // We need a custom comparer for TPriority 'int' to make it a max-heap.
        // Compares priority values (profits)
        var maxProfit = new PriorityQueue<int[], int>(Comparer<int>.Create((p1, p2) => p2.CompareTo(p1)));
        for (int i = 0; i < profits.Length; i++) {
            if (w >= capital[i]) {
                // Enqueue the project (int[]) with its profit as priority for the max-heap
                maxProfit.Enqueue(new int[] { profits[i], capital[i] }, profits[i]);
            } else {
                // Enqueue the project (int[]) with its capital as priority for the min-heap
                minCapital.Enqueue(new int[] { profits[i], capital[i] }, capital[i]);
            }
        }
        int count = 0;
        while (count < k && maxProfit.Count > 0) {
            // Dequeue returns the element (int[]), not the priority
            int[] temp = maxProfit.Dequeue();
            w += temp[0]; // Add profit to current capital
            count++;
            // Move projects from minCapital to maxProfit if current capital (w) is sufficient
            // Peek() returns the element (int[]), not the priority.
            while (minCapital.Count > 0 && minCapital.Peek()[1] <= w) {
                int[] project = minCapital.Dequeue();
                // Enqueue the moved project with its profit as priority into maxProfit heap
                maxProfit.Enqueue(project, project[0]);
            }
        }
        return w;
    }
}
}
