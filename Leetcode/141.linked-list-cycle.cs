/*
 * @lc app=leetcode id=141 lang=csharp
 *
 * [141] Linked List Cycle
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
    public bool HasCycle(ListNode head) {
        ListNode s = head, f = head;
        while (f != null && f.next != null)
        {
            s = s.next;
            f = f.next.next;
            if (s == f)
                return true;
        }
        
        return false;
    }
}
// @lc code=end

