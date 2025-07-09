namespace LeetCodeNet.G0101_0200.S0103_binary_tree_zigzag_level_order_traversal {

// #Medium #Top_Interview_Questions #Breadth_First_Search #Tree #Binary_Tree
// #Data_Structure_II_Day_15_Tree #Udemy_Tree_Stack_Queue #Top_Interview_150_Binary_Tree_BFS
// #2025_07_09_Time_0_ms_(100.00%)_Space_46.86_MB_(87.33%)

using System.Collections.Generic;
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var queue = new Queue<TreeNode>();
        var results = new List<IList<int>>();
        if (root == null) {
            return results;
        }
        var level = new List<int>();
        queue.Enqueue(root);
        queue.Enqueue(null);
        var d = false;
        while (queue.Count > 0) {
            var c = queue.Dequeue();
            if (c == null) {
                if (d) {
                    level.Reverse();
                }
                results.Add(level);
                if (queue.Count == 0) {
                    break;
                } else {
                    queue.Enqueue(null);
                    level = new List<int>();
                    d = !d;
                }
            } else {
                level.Add((int)c.val);
                if (c.left != null) {
                    queue.Enqueue(c.left);
                }
                if (c.right != null) {
                    queue.Enqueue(c.right);
                }
            }
        }
        return results;
    }
}
} 