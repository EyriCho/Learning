/*
 * @lc app=leetcode id=109 lang=csharp
 *
 * [109] Convert Sorted List to Binary Search Tree
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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head) {
        if (head == null)
        {
            return null;
        }

        if (head.next == null)
        {
            return new TreeNode(head.val);
        }

        var pre = head;
        var slow = head.next;
        var fast = head.next.next;

        while (fast != null && fast.next != null)
        {
            pre = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        pre.next = null;
        var root = new TreeNode(slow.val);
        root.left = SortedListToBST(head);
        root.right = SortedListToBST(slow.next);

        return root;
    }
}
// @lc code=end

