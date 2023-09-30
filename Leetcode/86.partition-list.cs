/*
 * @lc app=leetcode id=86 lang=csharp
 *
 * [86] Partition List
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
    public ListNode Partition(ListNode head, int x) {
        ListNode node = head,
            next = null,
            less = new ListNode(),
            great = new ListNode();
        ListNode l = less, g = great;
        
        while (node != null)
        {
            next = node.next;
            if (node.val < x)
            {
                l.next = node;
                l = node;
            }
            else
            {
                g.next = node;
                g = node;
            }
            
            node.next = null;
            node = next;
        }
        
        l.next = great.next;
        
        return less.next;
    }
}
// @lc code=end

