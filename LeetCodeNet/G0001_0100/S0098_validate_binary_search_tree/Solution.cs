namespace LeetCodeNet.G0001_0100.S0098_validate_binary_search_tree {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Depth_First_Search #Tree #Binary_Tree
// #Binary_Search_Tree #Data_Structure_I_Day_14_Tree #Level_1_Day_8_Binary_Search_Tree
// #Udemy_Tree_Stack_Queue #Top_Interview_150_Binary_Search_Tree #Big_O_Time_O(N)_Space_O(log(N))
// #2024_01_08_Time_75_ms_(97.31%)_Space_45.3_MB_(19.73%)

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
    public bool IsValidBST(TreeNode root) {
        return Solve(root, long.MinValue, long.MaxValue);
    }
    // we will send a valid range and check whether the root lies in the range
    // and update the range for the subtrees
    private bool Solve(TreeNode root, long left, long right) {
        if (root == null) {
            return true;
        }
        if (root.val <= left || root.val >= right) {
            return false;
        }
        return Solve(root.left, left, (long)root.val) && Solve(root.right, (long)root.val, right);
    }
}
}
