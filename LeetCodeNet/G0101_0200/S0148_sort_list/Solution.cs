namespace LeetCodeNet.G0101_0200.S0148_sort_list {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Sorting #Two_Pointers #Linked_List
// #Divide_and_Conquer #Merge_Sort #Level_2_Day_4_Linked_List #Top_Interview_150_Divide_and_Conquer
// #Big_O_Time_O(log(N))_Space_O(log(N)) #2025_06_14_Time_37_ms_(40.62%)_Space_76.59_MB_(5.13%)

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
    public ListNode SortList(ListNode head) {
        List<int> nums = new List<int>();
        ListNode temp = head;
        while (temp != null) {
            nums.Add(temp.val);
            temp = temp.next;
        }
        _ = new int[nums.Count()];
        int[] arr = nums.ToArray();
        Array.Sort(arr);
        temp = head;
        int i = 0;
        while (temp != null) {
            temp.val = arr[i];
            temp = temp.next;
            i++;
        }
        return head;
    }
}
}
