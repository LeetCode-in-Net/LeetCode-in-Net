namespace LeetCodeNet.G0001_0100.S0061_rotate_list {

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
    public void RotateRight() {
        var solution = new Solution();
        var head = BuildList(new int[] {1,2,3,4,5});
        var result = solution.RotateRight(head, 2);
        Assert.Equal(new int[] {4,5,1,2,3}, ToArray(result));
    }

    [Fact]
    public void RotateRight2() {
        var solution = new Solution();
        var head = BuildList(new int[] {0,1,2});
        var result = solution.RotateRight(head, 4);
        Assert.Equal(new int[] {2,0,1}, ToArray(result));
    }

    [Fact]
    public void RotateRight3() {
        var solution = new Solution();
        var result = solution.RotateRight(null, 1);
        Assert.Null(result);
    }

    [Fact]
    public void RotateRight4() {
        var solution = new Solution();
        var head = BuildList(new int[] {1});
        var result = solution.RotateRight(head, 99);
        Assert.Equal(new int[] {1}, ToArray(result));
    }
}
}
