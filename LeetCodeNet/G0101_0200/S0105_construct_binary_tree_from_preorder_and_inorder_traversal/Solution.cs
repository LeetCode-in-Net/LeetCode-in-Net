namespace LeetCodeNet.G0101_0200.S0105_construct_binary_tree_from_preorder_and_inorder_traversal {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Hash_Table #Tree #Binary_Tree
// #Divide_and_Conquer #Data_Structure_II_Day_15_Tree #Top_Interview_150_Binary_Tree_General
// #Big_O_Time_O(N)_Space_O(N) #2024_01_09_Time_53_ms_(99.83%)_Space_42.5_MB_(46.06%)

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
    private int j;
    private Dictionary<int, int> map = new Dictionary<int, int>();

    public int Get(int key) {
        return map[key];
    }

    private TreeNode Answer(int[] preorder, int[] inorder, int start, int end) {
        if (start > end || j > preorder.Length) {
            return null;
        }
        int value = preorder[j++];
        int index = Get(value);
        TreeNode node = new TreeNode(value);
        node.left = Answer(preorder, inorder, start, index - 1);
        node.right = Answer(preorder, inorder, index + 1, end);
        return node;
    }

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        j = 0;
        for (int i = 0; i < preorder.Length; i++) {
            map.Add(inorder[i], i);
        }
        return Answer(preorder, inorder, 0, preorder.Length - 1);
    }
}
}
