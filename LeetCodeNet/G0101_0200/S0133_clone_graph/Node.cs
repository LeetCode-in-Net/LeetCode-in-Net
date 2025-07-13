namespace LeetCodeNet.G0101_0200.S0133_clone_graph {

public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }

    public override string ToString() {
        var result = new System.Text.StringBuilder();
        result.Append('[');
        bool first = true;
        foreach (var node in neighbors) {
            if (!first) {
                result.Append(',');
            }
            if (node.neighbors == null || node.neighbors.Count == 0) {
                result.Append(node.val);
            } else {
                var inner = new System.Text.StringBuilder();
                inner.Append('[');
                bool innerFirst = true;
                foreach (var nodeItem in node.neighbors) {
                    if (!innerFirst) {
                        inner.Append(',');
                    }
                    inner.Append(nodeItem.val);
                    innerFirst = false;
                }
                inner.Append(']');
                result.Append(inner.ToString());
            }
            first = false;
        }
        result.Append(']');
        return result.ToString();
    }
}
}
