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
        int count = 0;
        ListNode node = head;
        while (node != null)
        {
            node = node.next;
            count++;
        }
        
        ListNode[] result = new ListNode[k];
        node = head;
        ListNode temp = new (),
            n = null;
        int size = count / k,
            left = count % k,
            c = 0;
        for (int i = 0; i < k; i++)
        {
            n = temp;
            temp.next = null;
            for (c = 0; c < size; c++)
            {
                n.next = node;
                node = node.next;
                n = n.next;
            }
            if (i < left)
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

