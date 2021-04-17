/*
 * @lc app=leetcode id=1721 lang=csharp
 *
 * [1721] Swapping Nodes in a Linked List
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
    public ListNode SwapNodes(ListNode head, int k) {
        ListNode from = head, behind = head;
        int i = 1;
        while (i++ < k)
            from = from.next;
        
        var tail = from;
        while (tail.next != null)
        {
            behind = behind.next;
            tail = tail.next;
        }
        
        if (from != behind)
        {
            from.val ^= behind.val;
            behind.val ^= from.val;
            from.val ^= behind.val;
        }
        
        return head;
    }
}
// @lc code=end

