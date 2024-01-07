namespace LeetCodeNet.G0201_0300.S0287_find_the_duplicate_number {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Binary_Search #Two_Pointers
// #Bit_Manipulation #Binary_Search_II_Day_5 #Big_O_Time_O(n)_Space_O(n)
// #2024_01_07_Time_257_ms_(30.11%)_Space_70.4_MB_(7.03%)

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
