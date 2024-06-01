/*
 * @lc app=leetcode id=2816 lang=csharp
 *
 * [2816] Double a Number Represented as a Linked List
 */

// @lc code=start
public class Solution {
    public ListNode DoubleIt(ListNode head) {
        
        ListNode Reverse(ListNode h)
        {
            ListNode curr = null,
                next = null,
                n = h;
            
            while (n != null)
            {
                next = n.next;
                n.next = curr;
                curr = n;
                n = next;
            }

            return curr;
        }

        head = Reverse(head);
        ListNode node = head,
            prev = null;
        int carry = 0;
        while (node != null)
        {
            node.val = node.val * 2 + carry;
            carry = node.val / 10;
            node.val %= 10;

            prev = node;
            node = node.next;
        }

        if (carry > 0)
        {
            prev.next = new ListNode(carry);
        }

        return Reverse(head);
    }
}
// @lc code=end

