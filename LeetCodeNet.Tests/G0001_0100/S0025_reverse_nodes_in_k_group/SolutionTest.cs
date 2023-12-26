namespace LeetCodeNet.G0001_0100.S0025_reverse_nodes_in_k_group {

using Xunit;
using System.Collections.Generic;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void ReverseKGroup() {
        ListNode head = LinkedListUtils.ConstructLinkedList(new int[] { 1, 2, 3, 4, 5 });
        Assert.Equal("2, 1, 4, 3, 5", new Solution().ReverseKGroup(head, 2).ToString());
    }

    [Fact]
    public void ReverseKGroup2() {
        ListNode head = LinkedListUtils.ConstructLinkedList(new int[] { 1, 2, 3, 4, 5 });
        Assert.Equal("3, 2, 1, 4, 5", new Solution().ReverseKGroup(head, 3).ToString());
    }
}
}
