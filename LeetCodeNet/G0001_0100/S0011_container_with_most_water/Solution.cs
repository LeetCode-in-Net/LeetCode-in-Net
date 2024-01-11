namespace LeetCodeNet.G0001_0100.S0011_container_with_most_water {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Greedy #Two_Pointers
// #Algorithm_II_Day_4_Two_Pointers #Big_O_Time_O(n)_Space_O(1)
// #2024_01_11_Time_251_ms_(30.70%)_Space_61.5_MB_(26.65%)

public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = -1;
        int left = 0;
        int right = height.Length - 1;
        while (left < right) {
            if (height[left] < height[right]) {
                maxArea = Math.Max(maxArea, height[left] * (right - left));
                left++;
            } else {
                maxArea = Math.Max(maxArea, height[right] * (right - left));
                right--;
            }
        }
        return maxArea;
    }
}
}
