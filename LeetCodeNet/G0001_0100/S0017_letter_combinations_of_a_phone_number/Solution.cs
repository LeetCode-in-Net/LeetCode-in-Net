namespace LeetCodeNet.G0001_0100.S0017_letter_combinations_of_a_phone_number {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #String #Hash_Table #Backtracking
// #Algorithm_II_Day_11_Recursion_Backtracking #Udemy_Backtracking/Recursion
// #Big_O_Time_O(4^n)_Space_O(n) #2023_12_26_Time_108_ms_(95.24%)_Space_46.3_MB_(5.39%)

using System.Text;

public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) {
            return new List<string>();
        }
        string[] letters = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
        IList<string> ans = new List<string>();
        StringBuilder sb = new StringBuilder();
        FindCombinations(0, digits, letters, sb, ans);
        return ans;
    }

    private void FindCombinations(
            int start, string nums, string[] letters, StringBuilder curr, IList<string> ans) {
        if (curr.Length == nums.Length) {
            ans.Add(curr.ToString());
            return;
        }
        for (int i = start; i < nums.Length; i++) {
            int n = int.Parse(nums[i].ToString());
            for (int j = 0; j < letters[n].Length; j++) {
                char ch = letters[n][j];
                curr.Append(ch);
                FindCombinations(i + 1, nums, letters, curr, ans);
                curr.Length--; // Equivalent to deleting the last character in StringBuilder
            }
        }
    }
}
}
