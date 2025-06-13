namespace LeetCodeNet.G0001_0100.S0084_largest_rectangle_in_histogram {

// #Hard #Top_100_Liked_Questions #Top_Interview_Questions #Array #Stack #Monotonic_Stack
// #Big_O_Time_O(n_log_n)_Space_O(log_n) #2025_06_13_Time_5_ms_(100.00%)_Space_57.76_MB_(41.84%)

public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int len = heights.Length;
        int maxArea = 0;
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i <= len; i++) {
            while (stack.Count > 0 && (i == len || heights[stack.Peek()] >= (i < len ? heights[i] : 0))) {
                int height = heights[stack.Pop()];
                int width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, height * width);
            }
            stack.Push(i);
        }
        return maxArea;
    }
}
}
