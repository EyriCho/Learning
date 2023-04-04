/*
 * @lc app=leetcode id=142 lang=csharp
 *
 * [142] Linked List Cycle II
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        ListNode node = head, fast = head;
        
        while (fast != null && fast.next != null)
        {
            node = node.next;
            fast = fast.next.next;
            if (node == fast)
            {
                break;
            }
        }
        
        if (fast == null || fast.next == null)
        {
            return null;
        }
        
        while (head != fast)
        {
            head = head.next;
            fast = fast.next;
        }
        
        return fast;
    }
}
// @lc code=end

