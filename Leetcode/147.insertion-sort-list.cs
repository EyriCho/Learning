/*
 * @lc app=leetcode id=147 lang=csharp
 *
 * [147] Insertion Sort List
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
    public ListNode InsertionSortList(ListNode head) {
        if (head == null || head.next == null)
            return head;
        ListNode lead = head.next,
            trail = head,
            fake = new ListNode(0, head);
        
        while (lead != null)
        {
            if (lead.val < trail.val)
            {
                trail.next = trail.next.next;
                var tmp = fake;
                while (lead.val > tmp.next.val)
                    tmp = tmp.next;
                lead.next = tmp.next;
                tmp.next = lead;
                
                lead = trail.next;
            }
            else
            {
                trail = trail.next;
                lead = trail.next;
            }
        }
        
        return fake.next;
    }
}
// @lc code=end

