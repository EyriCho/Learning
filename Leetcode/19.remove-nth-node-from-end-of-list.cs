/*
 * @lc app=leetcode id=19 lang=csharp
 *
 * [19] Remove Nth Node From End of List
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int i = 0;
        var fake = new ListNode(0, head);
        var node = fake;
        while (i++ < n)
        {
            node = node.next;
        }
        
        var prev = fake;
        while (node.next != null)
        {
            prev = prev.next;
            node = node.next;
        }
        
        prev.next = prev.next.next;
        
        return fake.next;
    }
}
// @lc code=end

