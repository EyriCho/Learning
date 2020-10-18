/*
 * @lc app=leetcode id=148 lang=csharp
 *
 * [148] Sort List
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
    public ListNode SortList(ListNode head) {
        if (head == null || head.next == null)
            return head;
        ListNode pre = head, slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            pre = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        pre.next = null;
        return Merge(SortList(head), SortList(slow));
    }
    
    private ListNode Merge(ListNode l, ListNode r)
    {
        var dummy = new ListNode();
        var node = dummy;
        while (l != null && r != null)
        {
            if (l.val < r.val)
            {
                node.next = l;
                l = l.next;
            }
            else
            {
                node.next = r;
                r = r.next;
            }
            node = node.next;
        }
        if (l != null)
            node.next = l;
        if (r != null)
            node.next = r;
        
        return dummy.next;
    }
}
// @lc code=end

