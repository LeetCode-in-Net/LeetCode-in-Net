namespace LeetCodeNet.G0001_0100.S0075_sort_colors {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Sorting #Two_Pointers
// #Data_Structure_II_Day_2_Array #Udemy_Arrays #Big_O_Time_O(n)_Space_O(1)
// #2024_01_05_Time_96_ms_(95.14%)_Space_44.8_MB_(20.40%)

public class Solution {
    public void SortColors(int[] nums) {
        var low = 0;
        var mid = 0;
        var high = nums.Length - 1;
        while (mid <= high) {
            if (nums[mid] == 0) {
                var temp = nums[low];
                nums[low] = nums[mid];
                nums[mid] = temp;
                mid++;
                low++;
            }
            else if (nums[mid] == 1) {
                mid++;
            }
            else {
                var temp = nums[mid];
                nums[mid] = nums[high];
                nums[high] = temp;
                high--;
            }
        }
    }
}
}
