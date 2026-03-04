Link: https://leetcode.com/problems/linked-list-cycle/
Language: C#







/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
        public bool HasCycle(ListNode head)
        {
            if (head == null) 
                return false;

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast) 
                    return true;
            }

            return false;
        }
}