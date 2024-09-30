/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [3217] Delete Nodes From Linked List Present in Array
 */

// @lc code=start
public class Solution {
    public ListNode ModifiedList(int[] nums, ListNode head) {
        HashSet<int> set = new (nums);

        ListNode faked = new (0, head),
            prev = faked,
            node = head;
        
        while (node != null)
        {
            if (set.Contains(node.val))
            {
                prev.next = node.next;
                node = prev.next;
            }
            else
            {
                prev = node;
                node = node.next;
            }
        }
        return faked.next;
    }
}
// @lc code=end

