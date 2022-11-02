/*
 * @lc app=leetcode id=2095 lang=csharp
 *
 * [2095] Delete the Middle Node of a Linked List
 */

// @lc code=start
public class Solution {
    public ListNode DeleteMiddle(ListNode head) {
        if (head.next == null)
        {
            return null;
        }
        
        ListNode mid = head,
            fast = head,
            prev = null;
        
        while (fast != null && fast.next != null)
        {
            prev = mid;
            mid = mid.next;
            fast = fast.next.next;
        }
        
        prev.next = mid.next;
        
        return head;
    }
}
// @lc code=end

