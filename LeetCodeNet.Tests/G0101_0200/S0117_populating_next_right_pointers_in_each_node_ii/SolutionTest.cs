namespace LeetCodeNet.G0101_0200.S0117_populating_next_right_pointers_in_each_node_ii {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Connect() {
        Assert.Null(new Solution().Connect(null));
    }

    [Fact]
    public void Connect2() {
        var node = new Node(
            1,
            new Node(2, new Node(4), new Node(5), null),
            new Node(3, null, new Node(7), null),
            null);

        var node7 = new Node(7);
        var node3 = new Node(3, null, node7, null);
        var node5 = new Node(5, null, null, node7);
        var node4 = new Node(4, null, null, node5);
        var node2 = new Node(2, node4, node5, node3);
        var node1 = new Node(1, node2, node3, null);

        Assert.Equal(node1.ToString(), new Solution().Connect(node).ToString());
    }

    [Fact]
    public void Connect3() {
        var node = new Node(
            1,
            new Node(2, new Node(4, new Node(7), null, null), new Node(5), null),
            new Node(3, null, new Node(6, null, new Node(8), null), null),
            null);

        var node8 = new Node(8, null, null, null);
        var node7 = new Node(7, null, null, node8);
        var node6 = new Node(6, null, node8, null);
        var node3 = new Node(3, null, node6, null);
        var node5 = new Node(5, null, null, node6);
        var node4 = new Node(4, node7, null, node5);
        var node2 = new Node(2, node4, node5, node3);
        var node1 = new Node(1, node2, node3, null);

        Assert.Equal(node1.ToString(), new Solution().Connect(node).ToString());
    }
}
}
