namespace LeetCodeNet.G0201_0300.S0287_find_the_duplicate_number {

// #Medium #Top_100_Liked_Questions #Array #Binary_Search #Two_Pointers #Bit_Manipulation
// #Binary_Search_II_Day_5 #Big_O_Time_O(n)_Space_O(n)
// #2025_06_16_Time_1_ms_(100.00%)_Space_72.10_MB_(32.30%)

public class Solution {
    public int FindDuplicate(int[] nums) {
        int[] arr = new int[nums.Length + 1];
        foreach (int num in nums) {
            arr[num] += 1;
            if (arr[num] == 2) {
                return num;
            }
        }
        return 0;
    }
}
}
