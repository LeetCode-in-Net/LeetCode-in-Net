namespace LeetCodeNet.Com_github_leetcode {

public class LinkedListUtils {
    public static ListNode ContructLinkedList(int[] nums) {
        if (nums == null || nums.Length == 0) {
            throw new ArgumentException(
                    "Please pass in a valid listValues to create a linked list.");
        }
        ListNode pre = new ListNode(-1);
        ListNode head = new ListNode(nums[0]);
        pre.next = head;
        for (int i = 1; i < nums.Length; i++) {
            head.next = new ListNode(nums[i]);
            head = head.next;
        }
        return pre.next;
    }

    public static ListNode CreateSinglyLinkedList(List<int> listValues) {
        if (listValues == null || listValues.Count == 0) {
            throw new ArgumentException(
                    "Please pass in a valid listValues to create a singly linked list.");
        }
        ListNode head = new ListNode(listValues[0]);
        ListNode tmp = head;
        for (int i = 1; i < listValues.Count; i++) {
            ListNode next = new ListNode(listValues[i]);
            tmp.next = next;
            tmp = tmp.next;
        }
        return head;
    }
}
}
