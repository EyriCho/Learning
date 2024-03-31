/*
 * @lc app=leetcode id=1669 lang=csharp
 *
 * [1669] Merge In Between Linked Lists
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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
        int i = 0;
        ListNode node1 = list1,
            remove = null;
        while (++i < a)
        {
            node1 = node1.next;
        }

        remove = node1.next;
        while (i++ < b)
        {
            remove = remove.next;
        }

        node1.next = list2;
        while (node1.next != null)
        {
            node1 = node1.next;
        }

        node1.next = remove.next;
        return list1;
    }
}
// @lc code=end

