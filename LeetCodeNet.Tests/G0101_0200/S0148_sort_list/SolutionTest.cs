namespace LeetCodeNet.G0101_0200.S0148_sort_list {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void SortList() {
        ListNode listNode1 = new ListNode(4);
        listNode1.next = new ListNode(2);
        listNode1.next.next = new ListNode(1);
        listNode1.next.next.next = new ListNode(3);
        Assert.Equal("1, 2, 3, 4", new Solution().SortList(listNode1).ToString());
    }

    [Fact]
    public void SortList2() {
        ListNode listNode1 = new ListNode(-1);
        listNode1.next = new ListNode(5);
        listNode1.next.next = new ListNode(3);
        listNode1.next.next.next = new ListNode(4);
        listNode1.next.next.next.next = new ListNode(0);
        Assert.Equal("-1, 0, 3, 4, 5", new Solution().SortList(listNode1).ToString());
    }

    [Fact]
    public void SortList3() {
        Assert.Equal(null, new Solution().SortList(null));
    }
}
}
