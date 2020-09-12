/*
 * @lc app=leetcode id=203 lang=csharp
 *
 * [203] Remove Linked List Elements
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
    public ListNode RemoveElements(ListNode head, int val) {
        if (head == null) return head;
        
        while (head != null && head.val == val)
        {
            head = head.next;
        }
        if (head == null) return null;
        var node = head;
        while (node.next != null)
        {
            if (node.next.val == val)
            {
                node.next = node.next.next;
            }
            else
            {
                node = node.next;                
            }
        }
        
        return head;        
    }
}
// @lc code=end

