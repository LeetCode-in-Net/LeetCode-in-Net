namespace LeetCodeNet.G0001_0100.S0086_partition_list {

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
        var list = new List<int>();
        while (head != null) {
            list.Add(head.val);
            head = head.next;
        }
        return list.ToArray();
    }

    [Fact]
    public void Partition() {
        var solution = new Solution();
        var head = BuildList(new int[] {1,4,3,2,5,2});
        var result = solution.Partition(head, 3);
        Assert.Equal(new int[] {1,2,2,4,3,5}, ToArray(result));
    }

    [Fact]
    public void Partition2() {
        var solution = new Solution();
        var head = BuildList(new int[] {2,1});
        var result = solution.Partition(head, 2);
        Assert.Equal(new int[] {1,2}, ToArray(result));
    }

    [Fact]
    public void Partition3() {
        var solution = new Solution();
        var head = BuildList(new int[] {1,2,3});
        var result = solution.Partition(head, 5);
        Assert.Equal(new int[] {1,2,3}, ToArray(result));
    }
}
}
