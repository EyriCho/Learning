/*
 * @lc app=leetcode id=2130 lang=csharp
 *
 * [2130] Maximum Twin Sum of a Linked List
 */

// @lc code=start
public class Solution {
    public int PairSum(ListNode head) {
        int result = 0;
        ListNode half = head,
            fast = head,
            reverse = null,
            next = null;
        
        while (fast != null)
        {
            fast = fast.next.next;
            next = half.next;
            half.next = reverse;
            reverse = half;
            half = next;
        }

        while (half != null)
        {
            result = Math.Max(result, half.val + reverse.val);
            half = half.next;
            reverse = reverse.next;
        }

        return result;
    }
}
// @lc code=end

