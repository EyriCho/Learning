/*
 * @lc app=leetcode id=160 lang=csharp
 *
 * [160] Intersection of Two Linked Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var n = headA;
        while (n.next != null)
        {
            n = n.next;
        }
        n.next = headB;
        
        ListNode GetLoopNode(ListNode node)
        {
            ListNode slow = node,
                fast = node.next;
            
            while (slow != fast)
            {
                if (fast.next == null || fast.next.next == null)
                {
                    return null;
                }
                slow = slow.next;
                fast = fast.next.next;
            }
            
            while (node != slow.next)
            {
                node = node.next;
                slow = slow.next;
            }
            
            return node;
        }
        
        var result = GetLoopNode(headA);
        n.next = null;
        return result;
    }
}
// @lc code=end

