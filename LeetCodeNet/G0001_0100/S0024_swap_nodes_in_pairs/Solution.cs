namespace LeetCodeNet.G0001_0100.S0024_swap_nodes_in_pairs {

// #Medium #Top_100_Liked_Questions #Linked_List #Recursion #Data_Structure_II_Day_12_Linked_List
// #Udemy_Linked_List #Big_O_Time_O(n)_Space_O(1)
// #2023_12_26_Time_58_ms_(98.51%)_Space_40_MB_(9.14%)

using LeetCodeNet.Com_github_leetcode;

public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if (head == null) {
            return null;
        }
        int len = GetLength(head);
        return Reverse(head, len);
    }

    private int GetLength(ListNode curr) {
        int cnt = 0;
        while (curr != null) {
            cnt++;
            curr = curr.next;
        }
        return cnt;
    }

    // Recursive function to reverse in groups
    private ListNode Reverse(ListNode head, int len) {
        // base case
        if (len < 2) {
            return head;
        }
        ListNode curr = head;
        ListNode prev = null;
        ListNode next;
        for (int i = 0; i < 2; i++) {
            // reverse linked list code
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        head.next = Reverse(curr, len - 2);
        return prev;
    }
}
}
