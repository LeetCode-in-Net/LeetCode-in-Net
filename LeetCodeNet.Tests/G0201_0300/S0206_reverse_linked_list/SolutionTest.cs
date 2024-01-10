namespace LeetCodeNet.G0201_0300.S0206_reverse_linked_list {

using Xunit;

public class SolutionTest {
    [Fact]
    public void ReverseList() {
        ListNode headActual = new ListNode(1);
        headActual.next = new ListNode(2);
        headActual.next.next = new ListNode(3);
        headActual.next.next.next = new ListNode(4);
        headActual.next.next.next.next = new ListNode(5);
        Assert.Equal("5, 4, 3, 2, 1", new Solution().ReverseList(headActual).ToString());
    }

    [Fact]
    public void ReverseList2() {
        ListNode headActual = new ListNode(1);
        headActual.next = new ListNode(2);
        Assert.Equal("2, 1", new Solution().ReverseList(headActual).ToString());
    }

    [Fact]
    public void ReverseList3() {
        Assert.Equal(null, new Solution().ReverseList(null));
    }
}
}
