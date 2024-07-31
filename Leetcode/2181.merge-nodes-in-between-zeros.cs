/*
 * @lc app=leetcode id=2181 lang=csharp
 *
 * [2181] Merge Nodes in Between Zeros
 */

// @lc code=start
public class Solution {
    public ListNode MergeNodes(ListNode head) {
        ListNode fake = new (0, head),
            node = fake,
            prev = fake,
            current = null;
        
        while (node != null)
        {
            while (node != null &&
                node.val == 0)
            {
                node = node.next;
            }

            if (node == null)
            {
                break;
            }

            current = node;
            node = node.next;
            current.next = null;
            while (node != null &&
                node.val > 0)
            {
                current.val += node.val;
                node = node.next;
            }
            prev.next = current;
            prev = current;
        }

        return fake.next;
    }
}
// @lc code=end

