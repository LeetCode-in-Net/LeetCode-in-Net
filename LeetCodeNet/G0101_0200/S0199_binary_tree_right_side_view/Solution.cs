namespace LeetCodeNet.G0101_0200.S0199_binary_tree_right_side_view {

// #Medium #Top_100_Liked_Questions #Depth_First_Search #Breadth_First_Search #Tree #Binary_Tree
// #LeetCode_75_Binary_Tree/BFS #Data_Structure_II_Day_16_Tree #Level_2_Day_15_Tree
// #Top_Interview_150_Binary_Tree_BFS #2025_07_13_Time_0_ms_(100.00%)_Space_47.47_MB_(41.96%)

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
    public IList<int> RightSideView(TreeNode root) {
        var list = new List<int>();
        Recurse(root, 0, list);
        return list;
    }

    private void Recurse(TreeNode node, int level, List<int> list) {
        if (node != null) {
            if (list.Count < level + 1) {
                list.Add(node.val.Value);
            }
            Recurse(node.right, level + 1, list);
            Recurse(node.left, level + 1, list);
        }
    }
}
}
