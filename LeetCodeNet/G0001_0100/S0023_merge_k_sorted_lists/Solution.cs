namespace LeetCodeNet.G0001_0100.S0023_merge_k_sorted_lists {

// #Hard #Top_100_Liked_Questions #Top_Interview_Questions #Heap_Priority_Queue #Linked_List
// #Divide_and_Conquer #Merge_Sort #Big_O_Time_O(k*n*log(k))_Space_O(log(k))
// #2023_12_26_Time_78_ms_(98.24%)_Space_45_MB_(13.27%)

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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0) {
            return null;
        }
        return MergeKLists(lists, 0, lists.Length);
    }

    private ListNode MergeKLists(ListNode[] lists, int leftIndex, int rightIndex) {
        if (rightIndex > leftIndex + 1) {
            int mid = (leftIndex + rightIndex) / 2;
            ListNode left = MergeKLists(lists, leftIndex, mid);
            ListNode right = MergeKLists(lists, mid, rightIndex);
            return MergeTwoLists(left, right);
        } else {
            return lists[leftIndex];
        }
    }

    private ListNode MergeTwoLists(ListNode left, ListNode right) {
        if (left == null) {
            return right;
        }
        if (right == null) {
            return left;
        }
        ListNode res;
        if (left.val <= right.val) {
            res = left;
            left = left.next;
        } else {
            res = right;
            right = right.next;
        }
        ListNode node = res;
        while (left != null || right != null) {
            if (left == null) {
                node.next = right;
                right = right.next;
            } else if (right == null) {
                node.next = left;
                left = left.next;
            } else {
                if (left.val <= right.val) {
                    node.next = left;
                    left = left.next;
                } else {
                    node.next = right;
                    right = right.next;
                }
            }
            node = node.next;
        }
        return res;
    }
}
}
