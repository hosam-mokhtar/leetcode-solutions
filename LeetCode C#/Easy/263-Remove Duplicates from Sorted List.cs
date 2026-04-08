Link: https://leetcode.com/problems/remove-duplicates-from-sorted-list/
Language: C#









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
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;

        ListNode curr = head;

        while (curr.next != null)
        {
            if (curr.next.val == curr.val)
                curr.next = curr.next.next;
            else
                curr = curr.next;
        }

        return head;
    }
}