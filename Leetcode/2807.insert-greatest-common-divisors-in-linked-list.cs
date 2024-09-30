/*
 * @lc app=leetcode id=2807 lang=csharp
 *
 * [2807] Insert Greatest Common Divisors in Linked List
 */

// @lc code=start
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
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        ListNode prev = head,
            node = head.next;

        int CommonDivisor(int a, int b)
        {
            int left = 1;
            while (left != 0)
            {
                left = a % b;
                a = b;
                b = left;
            }

            return a;
        }

        int c = 0;
        while (node != null)
        {
            c = CommonDivisor(prev.val, node.val);
            prev.next = new (c, node);
            prev = node;
            node = node.next;
        }

        return head;
    }
}
// @lc code=end

