namespace LeetCodeNet.G0601_0700.S0637_average_of_levels_in_binary_tree {

// #Easy #Depth_First_Search #Breadth_First_Search #Tree #Binary_Tree
// #Top_Interview_150_Binary_Tree_BFS #2025_07_18_Time_1_ms_(100.00%)_Space_50.69_MB_(89.38%)

using System;
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
    public IList<double> AverageOfLevels(TreeNode root) {
        IList<int> count = new List<int>();
        IList<double> avg = new List<double>();
        Average(root, 0, count, avg);
        for(int i = 0; i < count.Count; i++) {
            avg[i] /= count[i];
        }
        return avg;
    }

    private void Average(TreeNode node, int level, IList<int> count, IList<double> avg) {
        if (node == null) {
            return;
        }
        if (level < count.Count) {
            count[level]++;
            avg[level] += node.val;
        } else {
            count.Add(1);
            avg.Add(node.val);
        }
        Average(node.left, level+1, count, avg);
        Average(node.right, level+1, count, avg);
    }
}
}
