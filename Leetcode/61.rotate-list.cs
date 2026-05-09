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
        {
            return head;
        }

        ListNode node = head,
            prev = null,
            result = null;
        int count = 0;
        while (node != null)
        {
            count++;
            node = node.next;
        }

        k = k % count;
        if (k == 0)
        {
            return head;
        }

        k = count - k;
        node = head;
        while (k-- > 0)
        {
            prev = node;
            node = node.next;
        }

        result = node;
        prev.next = null;
        while (node.next != null)
        {
            node = node.next;
        }
        node.next = head;

        return result;
    }
}
// @lc code=end

