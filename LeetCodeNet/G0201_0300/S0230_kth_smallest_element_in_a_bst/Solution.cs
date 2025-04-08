namespace LeetCodeNet.G0201_0300.S0230_kth_smallest_element_in_a_bst {

// #Medium #Top_100_Liked_Questions #Depth_First_Search #Tree #Binary_Tree #Binary_Search_Tree
// #Data_Structure_II_Day_17_Tree #Level_2_Day_9_Binary_Search_Tree
// #Top_Interview_150_Binary_Search_Tree #Big_O_Time_O(n)_Space_O(n)
// #2024_01_10_Time_69_ms_(98.79%)_Space_45.2_MB_(12.59%)

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
    private int k;
    private int count = 0;
    private int val;

    public int KthSmallest(TreeNode root, int k) {
        this.k = k;
        Calculate(root);
        return val;
    }

    private void Calculate(TreeNode node) {
        if (node.left == null && node.right == null) {
            count++;
            if (count == k) {
                this.val = (int) node.val;
            }
            return;
        }
        if (node.left != null) {
            Calculate(node.left);
        }
        count++;
        if (count == k) {
            this.val = (int) node.val;
            return;
        }
        if (node.right != null) {
            Calculate(node.right);
        }
    }
}
}
