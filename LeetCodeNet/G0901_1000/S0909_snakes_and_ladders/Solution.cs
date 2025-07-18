namespace LeetCodeNet.G0901_1000.S0909_snakes_and_ladders {

// #Medium #Array #Breadth_First_Search #Matrix #Top_Interview_150_Graph_BFS
// #2025_07_18_Time_6_ms_(72.69%)_Space_46.25_MB_(32.25%)

using System;
using System.Collections.Generic;

public class Solution {
    private int size;

    public int SnakesAndLadders(int[][] board) {
        Queue<int> queue = new Queue<int>();
        size = board.Length;
        int target = size * size;
        // Using 0-indexed for visited array, corresponding to labels 1 to target
        bool[] visited = new bool[target];
        queue.Enqueue(1);
        // Mark label 1 as visited (index 0)
        visited[0] = true;
        int step = 0;
        while (queue.Count > 0) {
            int queueSize = queue.Count;
            for (int i = 0; i < queueSize; i++) {
                int previousLabel = queue.Dequeue();
                if (previousLabel == target) {
                    return step;
                }
                // Simulate rolling a die (1 to 6)
                for (int currentLabel = previousLabel + 1;
                     currentLabel <= Math.Min(target, previousLabel + 6);
                     currentLabel++) {
                    // currentLabel - 1 to map to 0-indexed array
                    if (visited[currentLabel - 1]) {
                        continue;
                    }
                    // Mark as visited
                    visited[currentLabel - 1] = true;
                    int[] position = IndexToPosition(currentLabel);
                    int boardValue = board[position[0]][position[1]];

                    if (boardValue == -1) {
                        queue.Enqueue(currentLabel);
                    } else {
                        queue.Enqueue(boardValue);
                    }
                }
            }
            step++;
        }
        // Target not reachable
        return -1;
    }

    private int[] IndexToPosition(int index) {
        // Adjust index to be 0-based for calculations related to 0 to size*size - 1
        int adjustedIndex = index - 1;
        // Calculate row
        // From bottom to top, so (size - 1) - (row based on adjustedIndex)
        int row = size - 1 - adjustedIndex / size;
        // Calculate column
        int col;
        // Check if the row is "snake" (even from bottom) or "ladder" (odd from bottom)
        // (size - 1 - row) gives the 0-indexed row number from the top of the board.
        // If (size - 1 - row) is even, it's a left-to-right row.
        // If (size - 1 - row) is odd, it's a right-to-left row.
        // The original Java code uses (this.size - vertical) % 2 == 1,
        // which corresponds to (row from top of board) % 2 == 1,
        // meaning if the row is odd (0-indexed from top), it's left-to-right
        // If row from top is 0 (bottom row), 2, 4... then it's left to right.
        // If row from top is 1, 3, 5... then it's right to left.
        // (size - 1 - row) is equivalent to the number of rows from the bottom.
        // (size - 1 - vertical) is a more direct translation from the Java code.
        if ((size - 1 - row) % 2 == 0) { // Even row from top (0-indexed), moves right (left to right)
            col = adjustedIndex % size;
        } else {
            // Odd row from top (0-indexed), moves left (right to left)
            col = size - 1 - (adjustedIndex % size);
        }
        return new int[] {row, col};
    }
}
}
