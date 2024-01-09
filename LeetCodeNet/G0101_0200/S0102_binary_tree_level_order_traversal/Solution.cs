namespace LeetCodeNet.G0101_0200.S0102_binary_tree_level_order_traversal {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Breadth_First_Search #Tree
// #Binary_Tree #Data_Structure_I_Day_11_Tree #Level_1_Day_6_Tree #Udemy_Tree_Stack_Queue
// #Big_O_Time_O(N)_Space_O(N) #2024_01_09_Time_97_ms_(98.14%)_Space_47.4_MB_(12.94%)

using LeetCodeNet.Com_github_leetcode;

/*
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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null) {
            return result;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        queue.Enqueue(null);
        List<int> level = new List<int>();
        while (queue.Count > 0) {
            root = queue.Dequeue();
            while (queue.Count > 0 && root != null) {
                level.Add((int)root.val);
                if (root.left != null) {
                    queue.Enqueue(root.left);
                }
                if (root.right != null) {
                    queue.Enqueue(root.right);
                }
                root = queue.Dequeue();
            }
            result.Add(level);
            level = new List<int>();
            if (queue.Count > 0) {
                queue.Enqueue(null);
            }
        }
        return result;
    }
}
}
