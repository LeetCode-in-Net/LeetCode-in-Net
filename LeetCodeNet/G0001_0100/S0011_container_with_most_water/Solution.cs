namespace LeetCodeNet.G0001_0100.S0011_container_with_most_water {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Greedy #Two_Pointers
// #Algorithm_II_Day_4_Two_Pointers #Big_O_Time_O(n)_Space_O(1)
// #2023_12_26_Time_248_ms_(11.15%)_Space_62.1_MB_(5.59%)

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
