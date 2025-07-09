namespace LeetCodeNet.G0101_0200.S0108_convert_sorted_array_to_binary_search_tree {

// #Easy #Top_Interview_Questions #Array #Tree #Binary_Tree #Binary_Search_Tree #Divide_and_Conquer
// #Data_Structure_II_Day_15_Tree #Level_2_Day_9_Binary_Search_Tree #Udemy_Tree_Stack_Queue
// #Top_Interview_150_Divide_and_Conquer #2025_07_09_Time_0_ms_(100.00%)_Space_45.24_MB_(54.95%)

using LeetCodeNet.Com_github_leetcode;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return MakeTree(nums, 0, nums.Length - 1);
    }

    private TreeNode MakeTree(int[] nums, int left, int right) {
        if (left > right) {
            return null;
        }
        int mid = (left + right) / 2;
        TreeNode midNode = new TreeNode(nums[mid]);
        midNode.left = MakeTree(nums, left, mid - 1);
        midNode.right = MakeTree(nums, mid + 1, right);
        return midNode;
    }
}
} 