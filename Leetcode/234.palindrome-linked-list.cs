/*
 * @lc app=leetcode id=234 lang=csharp
 *
 * [234] Palindrome Linked List
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
    public bool IsPalindrome(ListNode head) {
        ListNode mid = head,
            prev = null,
            fast = head.next;
        
        while (fast != null && fast.next != null)
        {
            var next = mid.next;
            mid.next = prev;
            prev = mid;
            mid = next;
            fast = fast.next.next;
        }
        
        ListNode l = prev, r = mid.next;
        if (fast != null)
        {
            mid.next = l;
            l = mid;
        }
        
        while (r != null)
        {
            if (l.val != r.val)
            {
                return false;
            }
            
            l = l.next;
            r = r.next;
        }
        
        return true;
    }
}
// @lc code=end

