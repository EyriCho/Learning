/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        ListNode dump = new ListNode(0);
        ListNode current = dump;
        while (l1 != null && l2 != null)
        {
            if (l1.val >= l2.val)
            {
                current.next = l1;
                current = l1;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                current = l2;
                l2 = l2.next;
            }
        }

        if (l1 != null) current.next = l1;
        if (l2 != null) current.next = l2;

        return dump.next;
    }
}
// @lc code=end

