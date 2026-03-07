namespace LeetCodeNet.Com_github_leetcode {

using System;
using System.Collections.Generic;

public class TreeNode {
    public int? val; //NOSONAR
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Compiler", "CS8618", Justification = "LeetCode")]
    public TreeNode left; //NOSONAR
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Compiler", "CS8618", Justification = "LeetCode")]
    public TreeNode right; //NOSONAR

    public TreeNode(int? val) { //NOSONAR
        this.val = val;
    }

    public TreeNode(int val, TreeNode left, TreeNode right) {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static TreeNode Create(List<int?> treeValues) {
        TreeNode root = treeValues.Count == 0 ? null! : new TreeNode(treeValues[0]);
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int i = 1;
        while (i < treeValues.Count) {
            TreeNode curr = queue.Dequeue();
            if (treeValues[i] != null) {
                curr.left = new TreeNode(treeValues[i]);
                queue.Enqueue(curr.left);
            }
            if (++i < treeValues.Count && treeValues[i] != null) {
                curr.right = new TreeNode(treeValues[i]);
                queue.Enqueue(curr.right);
            }
            i++;
        }
        return root;
    }

    public override string ToString() {
        if (left == null && right == null) {
            return "" + val;
        } else {
            string root = "" + val;
            string leftValue = "null";
            string rightValue = "null";
            if (left != null) {
                leftValue = left.ToString();
            }
            if (right != null) {
                rightValue = right.ToString();
            }
            return root + "," + leftValue + "," + rightValue;
        }
    }
}
}
