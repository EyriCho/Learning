/*
 * @lc app=leetcode id=725 lang=csharp
 *
 * [725] Split Linked List in Parts
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
    public ListNode[] SplitListToParts(ListNode head, int k) {
        var count = 0;
        var node = head;
        while (node != null)
        {
            count++;
            node = node.next;
        }

        var result = new ListNode[k];
        var num = count / k;
        var left = count % k;
        node = head;
        var temp = new ListNode();
        for (int i = 0; i < k; i++)
        {
            var n = temp;
            temp.next = null;
            var c = num + (i < left ? 1 : 0);
            while (c-- > 0)
            {
                n.next = node;
                node = node.next;
                n = n.next;
            }
            n.next = null;
            result[i] = temp.next;
        }
        return result;
    }
}
// @lc code=end

