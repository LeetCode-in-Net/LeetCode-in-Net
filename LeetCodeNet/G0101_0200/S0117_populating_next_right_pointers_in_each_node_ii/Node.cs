namespace LeetCodeNet.G0101_0200.S0117_populating_next_right_pointers_in_each_node_ii {

public class Node {
    public int val; //NOSONAR
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Compiler", "CS8618", Justification = "LeetCode")]
    public Node left; //NOSONAR
    public Node right; //NOSONAR
    public Node next; //NOSONAR

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Compiler", "CS8618", Justification = "LeetCode")]
    public Node() { }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Compiler", "CS8618", Justification = "LeetCode")]
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
}
