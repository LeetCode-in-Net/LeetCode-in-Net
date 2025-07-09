namespace LeetCodeNet.G0101_0200.S0112_path_sum {

// #Easy #Depth_First_Search #Breadth_First_Search #Tree #Binary_Tree #Data_Structure_I_Day_12_Tree
// #Top_Interview_150_Binary_Tree_General #2025_07_09_Time_0_ms_(100.00%)_Space_46.02_MB_(89.85%)

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
    public bool HasPathSum(TreeNode root, int sum) {
        if (root == null) {
            return false;
        }
        if (sum == root.val && root.left == null && root.right == null) {
            return true;
        }
        return HasPathSum(root.left, (int)(sum - root.val)) || HasPathSum(root.right, (int)(sum - root.val));
    }
}
} 