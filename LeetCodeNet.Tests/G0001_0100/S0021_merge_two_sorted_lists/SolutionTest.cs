namespace LeetCodeNet.G0001_0100.S0021_merge_two_sorted_lists {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void MergeTwoLists() {
        ListNode l1 = LinkedListUtils.CreateSinglyLinkedList(new List<int> { 1, 2, 4 });
        ListNode l2 = LinkedListUtils.CreateSinglyLinkedList(new List<int> { 1, 3, 4 });
        Assert.Equal("1, 1, 2, 3, 4, 4", new Solution().MergeTwoLists(l1, l2).ToString());
    }

    [Fact]
    public void MergeTwoLists2() {
        Assert.Equal("0, 0", new Solution().MergeTwoLists(new ListNode(), new ListNode()).ToString());
    }
}
}
