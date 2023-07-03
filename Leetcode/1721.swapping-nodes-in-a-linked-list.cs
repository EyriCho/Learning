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
        int count = 1;
        var node = head;
        
        while (count++ < k)
        {
            node = node.next;
        }

        var begin = node;

        var end = head;
        while (node.next != null)
        {
            end = end.next;
            node = node.next;
        }

        if (begin != end)
        {
            begin.val ^= end.val;
            end.val ^= begin.val;
            begin.val ^= end.val;
        }
        
        return head;
    }
}
// @lc code=end

