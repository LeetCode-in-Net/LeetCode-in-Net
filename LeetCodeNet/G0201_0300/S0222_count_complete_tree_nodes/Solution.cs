namespace LeetCodeNet.G0201_0300.S0222_count_complete_tree_nodes {

// #Easy #Depth_First_Search #Tree #Binary_Search #Binary_Tree #Binary_Search_II_Day_10
// #Top_Interview_150_Binary_Tree_General #2025_07_15_Time_0_ms_(100.00%)_Space_50.72_MB_(19.76%)

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
    public int CountNodes(TreeNode root) {
        if (root == null) {
            return 0;
        }
        int leftHeight = LeftHeight(root);
        int rightHeight = RightHeight(root);
        if (leftHeight == rightHeight) {
            return (1 << leftHeight) - 1;
        } else {
            return 1 + CountNodes(root.left) + CountNodes(root.right);
        }
    }

    private int LeftHeight(TreeNode root) {
        if (root == null) {
            return 0;
        }
        return 1 + LeftHeight(root.left);
    }

    private int RightHeight(TreeNode root) {
        if (root == null) {
            return 0;
        }
        return 1 + RightHeight(root.right);
    }
}
}
