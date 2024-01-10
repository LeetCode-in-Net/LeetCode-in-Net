namespace LeetCodeNet.G0201_0300.S0234_palindrome_linked_list {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void IsPalindrome() {
        ListNode headActual = new ListNode(1);
        headActual.next = new ListNode(2);
        headActual.next.next = new ListNode(2);
        headActual.next.next.next = new ListNode(1);
        Assert.True(new Solution().IsPalindrome(headActual));
    }

    [Fact]
    public void IsPalindrome2() {
        ListNode headActual = new ListNode(1);
        headActual.next = new ListNode(2);
        Assert.False(new Solution().IsPalindrome(headActual));
    }
}
}
