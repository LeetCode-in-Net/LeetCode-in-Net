namespace LeetCodeNet.G0001_0100.S0024_swap_nodes_in_pairs {

using Xunit;
using System.Collections.Generic;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void SwapPairs() {
        ListNode head = LinkedListUtils.CreateSinglyLinkedList(new List<int> { 1, 2, 3, 4 });
        Assert.Equal("2, 1, 4, 3", new Solution().SwapPairs(head).ToString());
    }

    [Fact]
    public void SwapPairs2() {
        Assert.Equal("1", new Solution().SwapPairs(new ListNode(1)).ToString());
    }
}
}
