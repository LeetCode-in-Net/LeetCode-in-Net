namespace LeetCodeNet.G0101_0200.S0114_flatten_binary_tree_to_linked_list {

// #Medium #Top_100_Liked_Questions #Depth_First_Search #Tree #Binary_Tree #Stack #Linked_List
// #Udemy_Linked_List #Top_Interview_150_Binary_Tree_General #Big_O_Time_O(N)_Space_O(N)
// #2024_01_09_Time_52_ms_(98.71%)_Space_41.3_MB_(6.68%)

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
    public void Flatten(TreeNode root) {
        if (root != null) {
            FindTail(root);
        }
    }

    private TreeNode FindTail(TreeNode root) {
        TreeNode left = root.left;
        TreeNode right = root.right;
        TreeNode tail;
        // find the tail of left subtree, tail means the most left leaf
        if (left != null) {
            tail = FindTail(left);
            // stitch the right subtree below the tail
            root.left = null;
            root.right = left;
            tail.right = right;
        } else {
            tail = root;
        }
        // find tail of the right subtree
        if (tail.right == null) {
            return tail;
        } else {
            return FindTail(tail.right);
        }
    }
}
}
