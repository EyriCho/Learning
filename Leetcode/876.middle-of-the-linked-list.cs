/*
 * @lc app=leetcode id=876 lang=csharp
 *
 * [876] Middle of the Linked List
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
    public ListNode MiddleNode(ListNode head) {
        ListNode node = head, mid = head;
        
        while (node != null && node.next != null)
        {
            node = node.next.next;
            mid = mid.next;
        }
        
        return mid;
    }
}
// @lc code=end

