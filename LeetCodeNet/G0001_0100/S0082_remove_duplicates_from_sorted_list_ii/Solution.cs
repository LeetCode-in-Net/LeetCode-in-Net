namespace LeetCodeNet.G0001_0100.S0082_remove_duplicates_from_sorted_list_ii {

// #Medium #Two_Pointers #Linked_List #Data_Structure_II_Day_11_Linked_List
// #Algorithm_II_Day_3_Two_Pointers #Top_Interview_150_Linked_List
// #2025_07_04_Time_0_ms_(100.00%)_Space_43.54_MB_(26.90%)

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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode dummy = new ListNode(0, head);
        ListNode prev = dummy;
        while (head != null) {
            if (head.next != null && head.val == head.next.val) {
                while (head.next != null && head.val == head.next.val) {
                    head = head.next;
                }
                prev.next = head.next;
            } else {
                prev = prev.next;
            }
            head = head.next;
        }
        return dummy.next;
    }
}
}
