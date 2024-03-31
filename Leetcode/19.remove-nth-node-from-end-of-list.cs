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
        ListNode faked = new ListNode(0, head),
            node = faked,
            prev = faked;

        int i = 0;
        while (i++ < n)
        {
            node = node.next;
        }

        while (node.next != null)
        {
            prev = prev.next;
            node = node.next;
        }

        prev.next = removed.next.next;

        return faked.next;
    }
}
// @lc code=end

