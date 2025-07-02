namespace LeetCodeNet.G0001_0100.S0061_rotate_list {

// #Medium #Two_Pointers #Linked_List #Programming_Skills_II_Day_16 #Udemy_Linked_List
// #Top_Interview_150_Linked_List #2025_07_02_Time_0_ms_(100.00%)_Space_43.04_MB_(61.65%)

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
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null || head.next == null || k == 0) {
            return head;
        }
        // Compute the length
        int len = 1;
        ListNode tail = head;
        while (tail.next != null) {
            tail = tail.next;
            len++;
        }
        k = k % len;
        if (k == 0) {
            return head;
        }
        // Make it a circle
        tail.next = head;
        // Find new tail: (len - k - 1)th node
        ListNode newTail = head;
        for (int i = 0; i < len - k - 1; i++) {
            newTail = newTail.next;
        }
        ListNode newHead = newTail.next;
        newTail.next = null;
        return newHead;
    }
}
}
