namespace LeetCodeNet.G0001_0100.S0015_3sum {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Sorting #Two_Pointers
// #Data_Structure_II_Day_1_Array #Algorithm_II_Day_3_Two_Pointers #Udemy_Two_Pointers
// #Top_Interview_150_Two_Pointers #Big_O_Time_O(n*log(n))_Space_O(n^2)
// #2023_12_26_Time_173_ms_(75.85%)_Space_74.7_MB_(28.23%)

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int len = nums.Length;
        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < len - 2; i++) {
            int l = i + 1;
            int r = len - 1;

            while (r > l) {
                int sum = nums[i] + nums[l] + nums[r];

                if (sum < 0) {
                    l++;
                } else if (sum > 0) {
                    r--;
                } else {
                    IList<int> list = new List<int> { nums[i], nums[l], nums[r] };
                    result.Add(list);

                    while (l < r && nums[l + 1] == nums[l]) {
                        l++;
                    }

                    while (r > l && nums[r - 1] == nums[r]) {
                        r--;
                    }

                    l++;
                    r--;
                }
            }

            while (i < len - 1 && nums[i + 1] == nums[i]) {
                i++;
            }
        }

        return result;
    }
}
}
