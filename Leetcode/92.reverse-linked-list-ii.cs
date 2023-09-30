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
        var faked = new ListNode(0, head);
        ListNode prev = faked, node = head;
        
        while (--left > 0)
        {
            prev = node;
            node = node.next;
            
            --right;
        }
        
        ListNode tail = node,
            next = node.next;
        while (--right > 0)
        {
            var temp = next.next;
            next.next = node;
            node = next;
            next = temp;
        }
        prev.next = node;
        tail.next = next;
        
        return faked.next;
    }
}
// @lc code=end

