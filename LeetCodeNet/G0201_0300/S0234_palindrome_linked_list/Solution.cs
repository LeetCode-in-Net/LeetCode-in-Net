namespace LeetCodeNet.G0201_0300.S0234_palindrome_linked_list {

// #Easy #Top_100_Liked_Questions #Two_Pointers #Stack #Linked_List #Recursion
// #Level_2_Day_3_Linked_List #Udemy_Linked_List #Big_O_Time_O(n)_Space_O(1)
// #2025_06_16_Time_4_ms_(60.29%)_Space_66.97_MB_(96.10%)

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
    public bool IsPalindrome(ListNode head) {
        int len = 0;
        ListNode right = head;
        // Calculate the length
        while (right != null) {
            right = right.next;
            len++;
        }
        // Reverse the right half of the list
        len = len / 2;
        right = head;
        for (int i = 0; i < len; i++) {
            right = right.next;
        }
        ListNode prev = null;
        while (right != null) {
            ListNode next = right.next;
            right.next = prev;
            prev = right;
            right = next;
        }
        // Compare left half and right half
        for (int i = 0; i < len; i++) {
            if (prev != null && head.val == prev.val) {
                head = head.next;
                prev = prev.next;
            } else {
                return false;
            }
        }
        return true;
    }
}
}
