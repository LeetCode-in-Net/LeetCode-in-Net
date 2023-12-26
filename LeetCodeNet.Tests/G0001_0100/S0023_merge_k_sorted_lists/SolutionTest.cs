namespace LeetCodeNet.G0001_0100.S0023_merge_k_sorted_lists {

using Xunit;
using System.Collections.Generic;

public class SolutionTest {
    [Fact]
    public void MergeKLists() {
        ListNode head1 = LinkedListUtils.CreateSinglyLinkedList(new List<int> { 1, 4, 5 });
        ListNode head2 = LinkedListUtils.CreateSinglyLinkedList(new List<int> { 1, 3, 4 });
        ListNode head3 = LinkedListUtils.CreateSinglyLinkedList(new List<int> { 2, 6 });
        Assert.Equal(
            "1, 1, 2, 3, 4, 4, 5, 6",
            new Solution().MergeKLists(new ListNode[] { head1, head2, head3 }).ToString()
        );
    }

    [Fact]
    public void MergeKLists2() {
        ListNode head1 = LinkedListUtils.CreateSinglyLinkedList(new List<int> { 1, 3, 5, 7, 11 });
        ListNode head2 = LinkedListUtils.CreateSinglyLinkedList(new List<int> { 2, 8, 12 });
        ListNode head3 = LinkedListUtils.CreateSinglyLinkedList(new List<int> { 4, 6, 9, 10 });
        Assert.Equal(
            "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12",
            new Solution().MergeKLists(new ListNode[] { head1, head2, head3 }).ToString()
        );
    }
}
}
