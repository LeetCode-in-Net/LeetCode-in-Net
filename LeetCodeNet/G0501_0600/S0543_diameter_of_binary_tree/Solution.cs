namespace LeetCodeNet.G0501_0600.S0543_diameter_of_binary_tree {

// #Easy #Top_100_Liked_Questions #Depth_First_Search #Tree #Binary_Tree #Level_2_Day_7_Tree
// #Udemy_Tree_Stack_Queue #Big_O_Time_O(n)_Space_O(n)
// #2024_01_07_Time_74_ms_(84.67%)_Space_42.6_MB_(8.90%)

public class Solution {
    private int diameter;

    public int DiameterOfBinaryTree(TreeNode root) {
        diameter = 0;
        DiameterOfBinaryTreeUtil(root);
        return diameter;
    }

    private int DiameterOfBinaryTreeUtil(TreeNode root) {
        if (root == null) {
            return 0;
        }
        int leftLength = root.left != null ? 1 + DiameterOfBinaryTreeUtil(root.left) : 0;
        int rightLength = root.right != null ? 1 + DiameterOfBinaryTreeUtil(root.right) : 0;
        diameter = Math.Max(diameter, leftLength + rightLength);
        return Math.Max(leftLength, rightLength);
    }
}
}
