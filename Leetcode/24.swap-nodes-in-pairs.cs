/*
 * @lc app=leetcode id=24 lang=csharp
 *
 * [24] Swap Nodes in Pairs
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
    public ListNode SwapPairs(ListNode head) {
        var fake = new ListNode(0, head);
        var prev = fake;
        var node = fake.next;
        
        while (node != null && node.next != null)
        {
            var next = node.next;
            node.next = next.next;
            prev.next = next;
            next.next = node;
            
            prev = node;
            node = node.next;
        }
        
        return fake.next;
    }
}
// @lc code=end

