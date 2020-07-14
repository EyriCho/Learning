/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = null;
        ListNode node = null;
        ListNode node1 = l1;
        ListNode node2 = l2;
        int up = 0;
        while (node1 != null || node2 != null || up > 0)
        {
            int sum = (node1?.val ?? 0) + (node2?.val ?? 0) + up;
            if (node == null)
            {
                node = new ListNode(sum % 10);
                result = node;
            }
            else
            {
                node.next = new ListNode(sum % 10);
                node = node.next;
            }
            up = sum / 10;
            node1 = node1?.next;
            node2 = node2?.next;
        }
        return result;
    }
}
// @lc code=end

