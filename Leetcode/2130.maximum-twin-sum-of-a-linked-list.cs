/*
 * @lc app=leetcode id=2130 lang=csharp
 *
 * [2130] Maximum Twin Sum of a Linked List
 */

// @lc code=start
public class Solution {
    public int PairSum(ListNode head) {
        ListNode node = head,
            fast = head,
            reverse = new ListNode();
        
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            var curr = node;
            node = node.next;
            curr.next = reverse.next;
            reverse.next = curr;
        }
        
        var result = 0;
        ListNode left = reverse.next,
            right = node;

        while (left != null)
        {
            result = Math.Max(result, left.val + right.val);
            left = left.next;
            right = right.next;
        }

        return result;
    }
}
// @lc code=end

