namespace LeetCodeNet.G0101_0200.S0133_clone_graph {

using Xunit;
using System.Collections.Generic;

public class SolutionTest {
    [Fact]
    public void CloneGraph() {
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);
        var node1and2and4 = new Node(1, new List<Node> {node2, node4});
        var node2and1and3 = new Node(2, new List<Node> {node1, node3});
        var node3and2and4 = new Node(3, new List<Node> {node2, node4});
        var node4and1and3 = new Node(4, new List<Node> {node1, node3});
        var node = new Node(5, new List<Node> {node1and2and4, node2and1and3, node3and2and4, node4and1and3});
        Assert.Equal("[[2,4],[1,3],[2,4],[1,3]]", new Solution().CloneGraph(node).ToString());
    }

    [Fact]
    public void CloneGraph2() {
        var node1 = new Node(1);
        Assert.Equal("[]", new Solution().CloneGraph(node1).ToString());
    }

    [Fact]
    public void CloneGraph3() {
        Assert.Null(new Solution().CloneGraph(null));
    }
}
}
