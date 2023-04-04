/*
 * @lc app=leetcode id=23 lang=csharp
 *
 * [23] Merge k Sorted Lists
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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0)
        {
            return null;
        }
        
        ListNode head = new ListNode(),
            node = head;
        
        while (node != null)
        {
            int min = -1;
            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null &&
                   (min < 0 || lists[i].val < lists[min].val))
                {
                    min = i;
                }
            }
            
            if (min >= 0)
            {
                node.next = lists[min];
                lists[min] = lists[min].next;
            }
            node = node.next;
        }
        
        return head.next;
    }
}
// @lc code=end

