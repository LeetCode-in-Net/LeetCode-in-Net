namespace LeetCodeNet.G0401_0500.S0437_path_sum_iii {

// #Medium #Top_100_Liked_Questions #Depth_First_Search #Tree #Binary_Tree #Level_2_Day_7_Tree
// #Big_O_Time_O(n)_Space_O(n) #2024_01_05_Time_76_ms_(97.16%)_Space_42.8_MB_(29.79%)

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
    private int count = 0;

    public int PathSum(TreeNode root, int targetSum) {
        if (root == null) {
            return 0;
        }
        Helper(root, targetSum, 0);
        PathSum(root.left, targetSum);
        PathSum(root.right, targetSum);
        return count;
    }

    public void Helper(TreeNode node, int targetSum, long currSum) {
        currSum += node.val;
        if (targetSum == currSum) {
            count++;
        }
        if (node.left != null) {
            Helper(node.left, targetSum, currSum);
        }
        if (node.right != null) {
            Helper(node.right, targetSum, currSum);
        }
    }
}
}
