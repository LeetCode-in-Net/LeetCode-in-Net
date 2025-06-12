namespace LeetCodeNet.G0001_0100.S0019_remove_nth_node_from_end_of_list {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Two_Pointers #Linked_List
// #Algorithm_I_Day_5_Two_Pointers #Level_2_Day_3_Linked_List #Top_Interview_150_Linked_List
// #Big_O_Time_O(L)_Space_O(L) #2025_06_12_Time_0_ms_(100.00%)_Space_42.68_MB_(23.67%)

using LeetCodeNet.Com_github_leetcode;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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
