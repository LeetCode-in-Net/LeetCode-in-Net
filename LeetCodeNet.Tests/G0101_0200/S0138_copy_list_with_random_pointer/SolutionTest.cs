namespace LeetCodeNet.G0101_0200.S0138_copy_list_with_random_pointer {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void CopyRandomList() {
        Node node7 = new Node(7);
        Node node13 = new Node(13);
        Node node11 = new Node(11);
        Node node10 = new Node(10);
        Node node1 = new Node(1);
        node7.next = node13;
        node13.next = node11;
        node11.next = node10;
        node10.next = node1;
        node1.next = null;
        node7.random = null;
        node13.random = node7;
        node11.random = node1;
        node10.random = node11;
        node1.random = node7;
        Assert.Equal(
            "[[7,null],[13,0],[11,4],[10,2],[1,0]]",
            new Solution().CopyRandomList(node7).ToString());
    }

    [Fact]
    public void CopyRandomList2() {
        Node node1 = new Node(1);
        Node node2 = new Node(2);
        node1.next = node2;
        node1.random = node1;
        node2.next = null;
        node2.random = node2;
        Assert.Equal("[[1,1],[2,1]]", new Solution().CopyRandomList(node1).ToString());
    }

    [Fact]
    public void CopyRandomList3() {
        Node node31 = new Node(3);
        Node node32 = new Node(3);
        Node node33 = new Node(3);
        node31.next = node32;
        node31.random = null;
        node32.next = node33;
        node32.random = node31;
        node33.next = null;
        node33.random = null;
        Assert.Equal("[[3,null],[3,0],[3,null]]", new Solution().CopyRandomList(node31).ToString());
    }
}
}
