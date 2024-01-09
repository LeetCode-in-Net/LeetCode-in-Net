namespace LeetCodeNet.G0101_0200.S0104_maximum_depth_of_binary_tree {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #Depth_First_Search #Breadth_First_Search
// #Tree #Binary_Tree #Data_Structure_I_Day_11_Tree
// #Programming_Skills_I_Day_10_Linked_List_and_Tree #Udemy_Tree_Stack_Queue
// #Big_O_Time_O(N)_Space_O(H) #2024_01_09_Time_65_ms_(93.31%)_Space_42.3_MB_(9.74%)

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
    public int MaxDepth(TreeNode root) {
        return FindDepth(root, 0);
    }

    private int FindDepth(TreeNode node, int currentDepth) {
        if (node == null) {
            return 0;
        }
        currentDepth++;
        return 1
                + Math.Max(FindDepth(node.left, currentDepth), FindDepth(node.right, currentDepth));
    }
}
}
