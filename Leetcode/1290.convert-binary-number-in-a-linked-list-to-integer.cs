/*
 * @lc app=leetcode id=1290 lang=csharp
 *
 * [1290] Convert Binary Number in a Linked List to Integer
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
    public int GetDecimalValue(ListNode head) {
         int i = 0;
        while (head != null)
        {
            i = (i << 1) + head.val;
            head = head.next;
        }
        
        return i;
    }
}
// @lc code=end

