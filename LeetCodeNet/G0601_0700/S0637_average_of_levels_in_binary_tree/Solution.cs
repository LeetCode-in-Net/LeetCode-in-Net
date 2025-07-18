namespace LeetCodeNet.G0601_0700.S0637_average_of_levels_in_binary_tree {

// #Easy #Depth_First_Search #Breadth_First_Search #Tree #Binary_Tree
// #Top_Interview_150_Binary_Tree_BFS #2025_07_18_Time_2_ms_(94.69%)_Space_51.54_MB_(10.31%)

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
        // Use Dictionary<int, Tuple<double, double>> to store (count, sum) for each level
        IDictionary<int, double[]> map = new Dictionary<int, double[]>();        
        Helper(root, map, 0);        
        IList<double> result = new List<double>();
        // Iterate through the dictionary values (which are the Double[] pairs)
        // Since dictionary iteration order is not guaranteed, and we need levels in order,
        // iterate up to the max level found.
        int maxLevel = 0;
        if (map.Count > 0) {
            foreach (var key in map.Keys) {
                if (key > maxLevel) {
                    maxLevel = key;
                }
            }
        }
        for (int i = 0; i <= maxLevel; i++) {
            if (map.TryGetValue(i, out double[] pair)) {
                double avg = pair[1] / pair[0];
                result.Add(avg);
            }
        }        
        return result;
    }

    private void Helper(TreeNode root, IDictionary<int, double[]> map, int level) {
        if (root == null) {
            return;
        }        
        // Get or create the pair for the current level
        if (!map.ContainsKey(level)) {
            // Initialize count and sum
            map[level] = new double[] {0.0, 0.0};
        }
        // Increment count        
        map[level][0] += 1;
        // Add value to sum
        map[level][1] += root.val;        
        Helper(root.left, map, level + 1);
        Helper(root.right, map, level + 1);
    }
}
}
