namespace LeetCodeNet.G0101_0200.S0148_sort_list {

    // #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Sorting #Two_Pointers #Linked_List
    // #Divide_and_Conquer #Merge_Sort #Level_2_Day_4_Linked_List #Big_O_Time_O(log(N))_Space_O(log(N))

using LeetCodeNet.Com_github_leetcode;

/*
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
