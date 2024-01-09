using LeetCodeNet.Com_github_leetcode;

public class TreeUtils {
    /*
    * This method is to construct a normal binary tree. The input reads like
    * this for [5, 3, 6, 2, 4, null, null, 1], i.e. preorder:
                   5
                 /   \
                3     6
               / \    / \
              2   4  #   #
             /
            1
    */
    public static TreeNode ConstructBinaryTree(List<int?> treeValues) {
        TreeNode root = new TreeNode(treeValues[0]);
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        for (int i = 1; i < treeValues.Count; i++) {
            TreeNode curr = queue.Dequeue();
            if (treeValues[i] != null) {
                curr.left = new TreeNode(treeValues[i]);
                queue.Enqueue(curr.left);
            }
            if (++i < treeValues.Count && treeValues[i] != null) {
                curr.right = new TreeNode(treeValues[i]);
                queue.Enqueue(curr.right);
            }
        }
        return root;
    }
}
