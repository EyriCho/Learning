/*
 * @lc app=leetcode id=61 lang=csharp
 *
 * [61] Rotate List
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
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null)
            return head;
        var node = head;
        
        int count = 0;
        while (node != null)
        {
            node = node.next;
            count++;
        }
        
        k %= count;
        if (k == 0)
            return head;
        k = count - k;
        
        node = head;
        ListNode result = null;
        for (int i = 0; i < count - 1; i++)
        {
            if (i == k - 1)
            {
                result = node.next;
                node.next = null;
                node = result;
            }
            else
                node = node.next;
        }
        node.next = head;
        return result;
    }
}
// @lc code=end

