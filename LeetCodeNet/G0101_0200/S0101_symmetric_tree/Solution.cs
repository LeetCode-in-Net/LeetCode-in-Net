namespace LeetCodeNet.G0101_0200.S0101_symmetric_tree {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #Depth_First_Search #Breadth_First_Search
// #Tree #Binary_Tree #Data_Structure_I_Day_11_Tree #Level_2_Day_15_Tree
// #Big_O_Time_O(N)_Space_O(log(N)) #2024_01_08_Time_64_ms_(97.79%)_Space_42.9_MB_(23.56%)

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
    public bool IsSymmetric(TreeNode root) {
        if (root == null) {
            return true;
        }
        return Helper(root.left, root.right);
    }

    private bool Helper(TreeNode leftNode, TreeNode rightNode) {
        if (leftNode == null || rightNode == null) {
            return leftNode == null && rightNode == null;
        }
        if (leftNode.val != rightNode.val) {
            return false;
        }
        return Helper(leftNode.left, rightNode.right) && Helper(leftNode.right, rightNode.left);
    }
}
}
