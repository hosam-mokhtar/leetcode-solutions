Link: https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
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
        public int GetDecimalValue(ListNode head)
        {
            int n = 0;
            
            while (head != null)
            {
                n *= 2;
                n += head.val;
                head = head.next;
            }

            return n;
        }
}