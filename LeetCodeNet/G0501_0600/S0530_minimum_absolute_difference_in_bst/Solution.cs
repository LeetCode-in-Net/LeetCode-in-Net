namespace LeetCodeNet.G0501_0600.S0530_minimum_absolute_difference_in_bst {

// #Easy #Depth_First_Search #Breadth_First_Search #Tree #Binary_Tree #Binary_Search_Tree
// #Top_Interview_150_Binary_Search_Tree #2025_07_18_Time_0_ms_(100.00%)_Space_46.22_MB_(60.28%)

using System;
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
    private int ans = int.MaxValue;
    private int? prev = null;

    public int GetMinimumDifference(TreeNode root) {
        InOrder(root);
        return ans;
    }
    
    private void InOrder(TreeNode node) {
        if (node == null) {
            return;
        }
        InOrder(node.left);
        if (prev != null) {
            ans = Math.Min(ans, Math.Abs((int) node.val - prev.Value));
        }
        prev = node.val;
        InOrder(node.right);
    }
}
}
