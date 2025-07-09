namespace LeetCodeNet.G0101_0200.S0117_populating_next_right_pointers_in_each_node_ii {

// #Medium #Depth_First_Search #Breadth_First_Search #Tree #Binary_Tree #Linked_List
// #Algorithm_II_Day_7_Breadth_First_Search_Depth_First_Search
// #Top_Interview_150_Binary_Tree_General #2025_07_09_Time_69_ms_(98.05%)_Space_45.58_MB_(89.45%)

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/
public class Solution {
    public Node Connect(Node root) {
        if (root == null) {
            return null;
        }
        if (root.left == null && root.right == null) {
            return root;
        }
        if (root.left != null) {
            if (root.right != null) {
                root.left.next = root.right;
            } else if (root.next != null) {
                root.left.next = AdjacentRightNode(root.next);
            }
        }
        if (root.right != null) {
            root.right.next = AdjacentRightNode(root.next);
        }
        Connect(root.right);
        Connect(root.left);
        return root;
    }

    private Node AdjacentRightNode(Node root) {
        Node temp = root;
        while (temp != null) {
            if (temp.left == null && temp.right == null) {
                temp = temp.next;
            } else {
                if (temp.left != null) {
                    return temp.left;
                }
                if (temp.right != null) {
                    return temp.right;
                }
            }
        }
        return null;
    }
}
}
