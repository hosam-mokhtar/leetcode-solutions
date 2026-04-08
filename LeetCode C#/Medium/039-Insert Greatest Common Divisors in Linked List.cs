Link: https://leetcode.com/problems/insert-greatest-common-divisors-in-linked-list/
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
            public int GCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }
            public ListNode InsertGreatestCommonDivisors(ListNode head)
            {
                ListNode curr = head;
                ListNode result = curr;

                while (head.next != null)
                {
                    int gcd = GCD(head.val, head.next.val);

                    ListNode temp = new ListNode(gcd);
                    head = head.next;
                    curr.next = temp;
                    curr = curr.next;
                    curr.next = head;
                    curr = curr.next;
                }

                return result;
            }
}