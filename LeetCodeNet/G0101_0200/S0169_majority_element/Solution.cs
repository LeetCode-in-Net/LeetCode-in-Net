namespace LeetCodeNet.G0101_0200.S0169_majority_element {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #Array #Hash_Table #Sorting #Counting
// #Divide_and_Conquer #Data_Structure_II_Day_1_Array #Udemy_Famous_Algorithm
// #Top_Interview_150_Array/String #Big_O_Time_O(n)_Space_O(1)
// #2025_06_14_Time_1_ms_(66.60%)_Space_50.05_MB_(28.42%)

public class Solution {
    public int MajorityElement(int[] arr) {
        int count = 1;
        int majority = arr[0];
        // For Potential Majority Element
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] == majority) {
                count++;
            } else {
                if (count > 1) {
                    count--;
                } else {
                    majority = arr[i];
                }
            }
        }
        // For Confirmation
        count = 0;
        foreach (int j in arr) {
            if (j == majority) {
                count++;
            }
        }
        if (count >= (arr.Length / 2) + 1) {
            return majority;
        } else {
            return -1;
        }
    }
}
}
