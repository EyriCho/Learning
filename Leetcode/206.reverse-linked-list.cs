/*
 * @lc app=leetcode id=206 lang=csharp
 *
 * [206] Reverse Linked List
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
    public ListNode ReverseList(ListNode head) {
        if (head == null)
        {
            return null;
        }

        ListNode prev = null,
            node = head,
            next = head;
        
        while (node != null)
        {
            next = node.next;
            node.next = prev;
            prev = node;
            node = next;
        }

        return prev;
    }
}
// @lc code=end

