namespace LeetCodeNet.G0101_0200.S0167_two_sum_ii_input_array_is_sorted {

// #Medium #Array #Binary_Search #Two_Pointers #Algorithm_I_Day_3_Two_Pointers
// #Binary_Search_I_Day_7 #Top_Interview_150_Two_Pointers
// #2025_07_13_Time_0_ms_(100.00%)_Space_50.79_MB_(76.45%)

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] res = new int[2];
        int i = 0;
        int j = numbers.Length - 1;
        while (i < j) {
            int sum = numbers[i] + numbers[j];
            if (sum == target) {
                res[0] = i + 1;
                res[1] = j + 1;
                return res;
            } else if (sum < target) {
                i++;
            } else {
                j--;
            }
        }
        return res;
    }
}
}
