namespace LeetCodeNet.G0001_0100.S0100_same_tree {

// #Easy #Depth_First_Search #Breadth_First_Search #Tree #Binary_Tree #Level_2_Day_15_Tree
// #Udemy_Tree_Stack_Queue #Top_Interview_150_Binary_Tree_General
// #2025_07_05_Time_0_ms_(100.00%)_Space_43.13_MB_(97.44%)

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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;
        if (p.val != q.val) return false;
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
}
