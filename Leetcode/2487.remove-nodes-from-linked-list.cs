/*
 * @lc app=leetcode id=2487 lang=csharp
 *
 * [2487] Remove Nodes From Linked List
 */

// @lc code=start
public class Solution {
    public ListNode RemoveNodes(ListNode head) {
        Stack<ListNode> stack = new();
        ListNode newHead = head;

        while (head != null) {
            while (stack.Count > 0 && stack.Peek().val < head.val)
                stack.Pop();
            if (stack.Count == 0)
                newHead = head;
            else
                stack.Peek().next = head;
            
            stack.Push(head);
            head = head.next;
        }

        return newHead;
    }
}
// @lc code=end

