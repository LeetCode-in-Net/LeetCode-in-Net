namespace LeetCodeNet.G0101_0200.S0142_linked_list_cycle_ii {

using System;
using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void DetectCycleTest1() {
        ListNode listNode1 = new ListNode(3);
        listNode1.next = new ListNode(2);
        listNode1.next.next = new ListNode(0);
        listNode1.next.next.next = new ListNode(-4);
        listNode1.next.next.next.next = listNode1.next;
        Assert.True(new Solution().DetectCycle(listNode1) == listNode1.next);
    }

    [Fact]
    public void DetectCycleTest2() {
        ListNode listNode1 = new ListNode(1);
        listNode1.next = new ListNode(2);
        listNode1.next.next = listNode1;
        Assert.True(new Solution().DetectCycle(listNode1) == listNode1);
    }

    [Fact]
    public void DetectCycleTest3() {
        ListNode listNode1 = new ListNode(1);
        Assert.Equal(null, new Solution().DetectCycle(listNode1));
    }
}
}
