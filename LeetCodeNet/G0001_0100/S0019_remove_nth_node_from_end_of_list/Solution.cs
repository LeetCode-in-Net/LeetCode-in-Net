namespace LeetCodeNet.G0001_0100.S0019_remove_nth_node_from_end_of_list {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Two_Pointers #Linked_List
// #Algorithm_I_Day_5_Two_Pointers #Level_2_Day_3_Linked_List #Big_O_Time_O(L)_Space_O(L)

using LeetCodeNet.Com_github_leetcode;

public class Solution {
    private int n;

    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        this.n = n;
        ListNode node = new ListNode(0, head);
        RemoveNth(node);
        return node.next;
    }

    private void RemoveNth(ListNode node) {
        if (node.next == null) {
            return;
        }
        RemoveNth(node.next);
        this.n--;

        if (this.n == 0) {
            node.next = node.next.next;
        }
    }
}
}
