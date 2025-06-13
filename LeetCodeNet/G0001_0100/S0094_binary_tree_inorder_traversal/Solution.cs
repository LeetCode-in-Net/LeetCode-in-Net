namespace LeetCodeNet.G0001_0100.S0094_binary_tree_inorder_traversal {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #Depth_First_Search #Tree #Binary_Tree
// #Stack #Data_Structure_I_Day_10_Tree #Udemy_Tree_Stack_Queue #Big_O_Time_O(n)_Space_O(n)
// #2025_06_13_Time_0_ms_(100.00%)_Space_46.64_MB_(63.38%)

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
    public IList<int> InorderTraversal(TreeNode root) {
        if (root == null) {
            return new List<int>();
        }
        var answer = new List<int>();
        InorderTraversal(root, answer);
        return answer;
    }

    private void InorderTraversal(TreeNode root, IList<int> answer) {
        if (root == null) {
            return;
        }
        if (root.left != null) {
            InorderTraversal(root.left, answer);
        }
        answer.Add((int)root.val);
        if (root.right != null) {
            InorderTraversal(root.right, answer);
        }
    }
}
}
