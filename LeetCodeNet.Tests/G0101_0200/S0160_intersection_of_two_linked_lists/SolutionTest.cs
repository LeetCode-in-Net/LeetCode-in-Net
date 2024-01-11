namespace LeetCodeNet.G0101_0200.S0160_intersection_of_two_linked_lists {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void GetIntersectionNode() {
        ListNode intersectionListNode = new ListNode(8, new ListNode(4, new ListNode(5)));
        ListNode nodeA = new ListNode(4, new ListNode(1, intersectionListNode));
        ListNode nodeB = new ListNode(5, new ListNode(6, new ListNode(1, intersectionListNode)));
        Assert.Equal(8, new Solution().GetIntersectionNode(nodeA, nodeB).val);
    }

    [Fact]
    public void GetIntersectionNode2() {
        ListNode nodeA = new ListNode(4, new ListNode(1, new ListNode(2)));
        ListNode nodeB = new ListNode(5, new ListNode(6, new ListNode(1, new ListNode(2))));
        Assert.Equal(null, new Solution().GetIntersectionNode(nodeA, nodeB));
    }
}
}
