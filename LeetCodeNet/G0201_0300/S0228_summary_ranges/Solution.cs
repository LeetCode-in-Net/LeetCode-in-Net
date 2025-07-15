namespace LeetCodeNet.G0201_0300.S0228_summary_ranges {

// #Easy #Array #Top_Interview_150_Intervals #2025_07_15_Time_0_ms_(100.00%)_Space_47.48_MB_(50.51%)

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> result = new List<string>();
        if (nums.Length == 0) {
            return result;
        }
        int startIndex = 0;
        for (int i = 1; i < nums.Length; ++i) {
            if (nums[i] == nums[i - 1] + 1) {
                continue;
            }
            else {
                if (startIndex != i - 1) {
                    result.Add(nums[startIndex] + "->" + (nums[i - 1]).ToString());
                } else {
                    result.Add(nums[startIndex].ToString());
                }
                startIndex = i;
            }
        }
        if (startIndex != nums.Length - 1) {
            result.Add(nums[startIndex] + "->" + (nums[nums.Length - 1]).ToString());
        } else {
            result.Add(nums[startIndex].ToString());
        }
        return result;
    }
}
}
