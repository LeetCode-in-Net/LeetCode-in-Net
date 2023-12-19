namespace LeetCodeNet.G0001_0100.S0002_add_two_numbers {

using Xunit;
using LeetCodeNet.Com_github_leetcode.ListNode;
using LeetCodeNet.Com_github_leetcode.LinkedListUtils;

public class SolutionTest {
    [Fact]
    public void AddTwoNumbers() {
        ListNode listNode1 = LinkedListUtils.ContructLinkedList(new int[] {2, 4, 3});
        ListNode listNode2 = LinkedListUtils.ContructLinkedList(new int[] {5, 6, 4});
        Assert.Equal("7, 0, 8", new Solution().AddTwoNumbers(listNode1, listNode2).ToString());
    }

    [Fact]
    public void AddTwoNumbers2() {
        Assert.Equal("0", new Solution().AddTwoNumbers(new ListNode(0), new ListNode(0)).ToString());
    }

    [Fact]
    public void AddTwoNumbers3() {
        ListNode listNode1 = LinkedListUtils.ContructLinkedList(new int[] {9, 9, 9, 9, 9, 9, 9});
        ListNode listNode2 = LinkedListUtils.ContructLinkedList(new int[] {9, 9, 9, 9});
        Assert.Equal("8, 9, 9, 9, 0, 0, 0, 1", new Solution().AddTwoNumbers(listNode1, listNode2).ToString());
    }
}
}
