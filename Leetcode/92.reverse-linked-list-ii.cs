/*
 * @lc app=leetcode id=92 lang=csharp
 *
 * [92] Reverse Linked List II
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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        ListNode faked = new ListNode(0, head);
        ListNode prev = faked, node = head;
        
        int i = 0;
        while (++i != left)
        {
            prev = node;
            node = node.next;
        }
        
        ListNode revPrev = prev, revTail = node,
            next = node.next;
        while (i++ != right)
        {
            var temp = next.next;
            next.next = node;
            node = next;
            next = temp;
        }
        revPrev.next = node;
        revTail.next = next;
        
        return faked.next;
    }
}
// @lc code=end

