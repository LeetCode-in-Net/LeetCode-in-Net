namespace LeetCodeNet.G0101_0200.S0124_binary_tree_maximum_path_sum {

// #Hard #Top_100_Liked_Questions #Top_Interview_Questions #Dynamic_Programming #Depth_First_Search
// #Tree #Binary_Tree #Udemy_Tree_Stack_Queue #Big_O_Time_O(N)_Space_O(N)
// #2024_01_09_Time_85_ms_(91.69%)_Space_47.6_MB_(23.52%)

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
    private int max = int.MinValue;

    private int Helper(TreeNode root) {
        if (root == null) {
            return 0;
        }
        // to avoid the -ve values in left side we will compare them with 0
        int left = Math.Max(0, Helper(root.left));
        int right = Math.Max(0, Helper(root.right));
        int current = (int)(root.val + left + right);
        if (current > max) {
            max = current;
        }
        return (int)(root.val + Math.Max(left, right));
    }

    public int MaxPathSum(TreeNode root) {
        Helper(root);
        return max;
    }
}
}
