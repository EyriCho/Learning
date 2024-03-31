/*
 * @lc app=leetcode id=143 lang=csharp
 *
 * [143] Reorder List
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
    public void ReorderList(ListNode head) {
        ListNode mid = head,
            last = head;
        
        while (last != null && last.next != null)
        {
            mid = mid.next;
            last = last.next.next;
        }

        ListNode next = null,
            prev = null,
            node = mid;
        while (node != null)
        {
            next = node.next;
            node.next = prev;
            prev = node;
            node = next;
        }

        ListNode front = head,
            tail = prev;

        while (front != null && tail != null)
        {

            Console.WriteLine($"{front.val}, {tail.val}");
            next = front.next;
            front.next = tail;
            front = next;

            next = tail.next;
            tail.next = front;
            tail = next;
        }

        if (front != null)
        {
            front.next = null;
        }
    }
}
// @lc code=end

