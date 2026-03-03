namespace LeetCodeNet.Com_github_leetcode {

using System.Text;

public class ListNode {
    public int val;
    public ListNode? next;

    public ListNode() {}

    public ListNode(int val) {
        this.val = val;
    }

    public ListNode(int val, ListNode next) {
        this.val = val;
        this.next = next;
    }

    public override string ToString() {
        StringBuilder result = new StringBuilder(val.ToString());
        if (next != null) {
            ListNode current = next;
            while (current.next != null) {
                result.Append(", ");
                result.Append(current.val);
                current = current.next;
            }
            result.Append(", ");
            result.Append(current.val);
        }
        return result.ToString();
    }
}
}
