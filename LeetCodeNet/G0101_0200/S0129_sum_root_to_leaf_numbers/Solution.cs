namespace LeetCodeNet.G0101_0200.S0129_sum_root_to_leaf_numbers {

// #Medium #Depth_First_Search #Tree #Binary_Tree #Top_Interview_150_Binary_Tree_General
// #2025_07_12_Time_0_ms_(100.00%)_Space_41.52_MB_(70.15%)

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
    private int sum = 0;

    public int SumNumbers(TreeNode root) {
        RecurseSum(root, 0);
        return sum;
    }

    private void RecurseSum(TreeNode node, int curNum) {
        if (node.left == null && node.right == null) {
            sum += 10 * curNum + node.val.Value;
        } else {
            if (node.left != null) {
                RecurseSum(node.left, 10 * curNum + node.val.Value);
            }
            if (node.right != null) {
                RecurseSum(node.right, 10 * curNum + node.val.Value);
            }
        }
    }
}
}
