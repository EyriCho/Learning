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
        if (head == null || head.next == null) return;
        
        var slow = head;
        var fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        // reverse seconde half
        ListNode prev = null;
        var node = slow;
        ListNode next = null;
        while (node != null)
        {
            next = node.next;
            node.next = prev;
            prev = node;
            node = next;
        }
        
        var first = head;
        var second = prev;
        while (first != null && second != null)
        {
            var n = first.next;
            first.next = second;
            first = n;
            
            n = second.next;
            second.next = first;
            second = n;
        }
        
        if (first != null)
            first.next = null;
    }
}
// @lc code=end

