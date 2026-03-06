namespace LeetCodeNet.G0001_0100.S0001_two_sum {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #Array #Hash_Table
// #Data_Structure_I_Day_2_Array #Level_1_Day_13_Hashmap #Udemy_Arrays #Top_Interview_150_Hashmap
// #Big_O_Time_O(n)_Space_O(n) #AI_can_be_used_to_solve_the_task
// #2025_06_12_Time_1_ms_(98.51%)_Space_49.32_MB_(14.31%)

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> indexMap = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++) {
            int requiredNum = target - numbers[i];
            if (indexMap.ContainsKey(requiredNum)) {
                return new int[] {indexMap[requiredNum], i};
            }
            indexMap[numbers[i]] = i;
        }
        return new int[] {-1, -1};
    }
}
}
