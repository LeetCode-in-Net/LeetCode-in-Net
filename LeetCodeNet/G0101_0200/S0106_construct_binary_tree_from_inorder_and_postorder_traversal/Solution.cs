namespace LeetCodeNet.G0101_0200.S0106_construct_binary_tree_from_inorder_and_postorder_traversal {

// #Medium #Array #Hash_Table #Tree #Binary_Tree #Divide_and_Conquer
// #Top_Interview_150_Binary_Tree_General #2025_07_09_Time_0_ms_(100.00%)_Space_44.29_MB_(90.60%)

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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        int inIndex = inorder.Length - 1;
        int postIndex = postorder.Length - 1;
        return Helper(inorder, postorder, ref inIndex, ref postIndex, int.MaxValue);
    }

    private TreeNode Helper(int[] inorder, int[] postorder, ref int inIndex, ref int postIndex, int target) {
        if (inIndex < 0 || inorder[inIndex] == target) {
            return null;
        }
        TreeNode root = new TreeNode(postorder[postIndex--]);
        root.right = Helper(inorder, postorder, ref inIndex, ref postIndex, (int)root.val);
        inIndex--;
        root.left = Helper(inorder, postorder, ref inIndex, ref postIndex, target);
        return root;
    }
}
} 