namespace LeetCodeNet.G0001_0100.S0019_remove_nth_node_from_end_of_list {

using Xunit;

public class SolutionTest {
    [Fact]
    public void RemoveNthFromEnd() {
        ListNode node1 = LinkedListUtils.ConstructLinkedList(new int[] { 1, 2, 3, 4, 5 });
        Assert.Equal("1, 2, 3, 5", new Solution().RemoveNthFromEnd(node1, 2).ToString());
    }

    [Fact]
    public void RemoveNthFromEnd2() {
        ListNode node1 = new ListNode(1);
        Assert.Null(new Solution().RemoveNthFromEnd(node1, 1));
    }
}
}
