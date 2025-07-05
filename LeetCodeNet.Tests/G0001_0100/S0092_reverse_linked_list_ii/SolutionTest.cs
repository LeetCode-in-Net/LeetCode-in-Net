namespace LeetCodeNet.G0001_0100.S0092_reverse_linked_list_ii {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    private ListNode BuildList(int[] vals) {
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        foreach (var v in vals) {
            curr.next = new ListNode(v);
            curr = curr.next;
        }
        return dummy.next;
    }

    private int[] ToArray(ListNode head) {
        var list = new System.Collections.Generic.List<int>();
        while (head != null) {
            list.Add(head.val);
            head = head.next;
        }
        return list.ToArray();
    }

    [Fact]
    public void ReverseBetween() {
        var solution = new Solution();
        var head = BuildList(new int[] {1,2,3,4,5});
        var result = solution.ReverseBetween(head, 2, 4);
        Assert.Equal(new int[] {1,4,3,2,5}, ToArray(result));
    }

    [Fact]
    public void ReverseBetween2() {
        var solution = new Solution();
        var head = BuildList(new int[] {5});
        var result = solution.ReverseBetween(head, 1, 1);
        Assert.Equal(new int[] {5}, ToArray(result));
    }

    [Fact]
    public void ReverseBetween3() {
        var solution = new Solution();
        var head = BuildList(new int[] {1,2,3});
        var result = solution.ReverseBetween(head, 1, 3);
        Assert.Equal(new int[] {3,2,1}, ToArray(result));
    }
}
}
