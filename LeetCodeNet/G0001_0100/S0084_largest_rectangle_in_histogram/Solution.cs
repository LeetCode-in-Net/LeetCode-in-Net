namespace LeetCodeNet.G0001_0100.S0084_largest_rectangle_in_histogram {

    // #Hard #Top_100_Liked_Questions #Top_Interview_Questions #Array #Stack #Monotonic_Stack
    // #Big_O_Time_O(n_log_n)_Space_O(log_n) #2024_01_08_Time_304_ms_(30.92%)_Space_52.4_MB_(29.92%)

    public class Solution {
        public int LargestRectangleArea(int[] heights) {
            int maxArea = 0, i = 0;
            Stack<int> stack = new Stack<int>();
            while (i <= heights.Length) {
                var currHeight = i == heights.Length ? 0 : heights[i];
                if (!stack.Any() || currHeight >= heights[stack.Peek()]) {
                    stack.Push(i);
                    i++;
                }
                else {
                    int index = stack.Pop();
                    int height = heights[index];
                    int width = (!stack.Any()) ? i : (i - 1) - stack.Peek();
                    maxArea = Math.Max(maxArea, height * width);
                }
            }
            return maxArea;
        }
    }
}
