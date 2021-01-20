/*
 * @lc app=leetcode id=82 lang=csharp
 *
 * [82] Remove Duplicates from Sorted List II
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
    public ListNode DeleteDuplicates(ListNode head) {
        var fake = new ListNode(-1, head);
        var prev = fake;
        var node = head;
        while (node != null)
        {
            var count = 1;
            var next = node.next;
            while (next != null && next.val == node.val)
            {
                next = next.next;
                count++;
            }
            
            if (count > 1)
            {
                prev.next = next;
                node = next;
            }
            else
            {
                prev = node;
                node = next;
            }
        }
        
        return fake.next;
    }
}
// @lc code=end

