/*
 * @lc app=leetcode id=1367 lang=csharp
 *
 * [1367] Linked List in Binary Tree
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
    public bool IsSubPath(ListNode head, TreeNode root) {
        if (head == null)
        {
            return true;
        }

        if (root == null)
        {
            return false;
        }

        bool Dfs(ListNode l, TreeNode t)
        {
            if (l == null)
            {
                return true;
            }
            if (t == null)
            {
                return false;
            }

            return l.val == t.val && (Dfs(l.next, t.left) || Dfs(l.next, t.right));
        }

        return Dfs(head, root) || IsSubPath(head, root.left) || IsSubPath(head, root.right);
    }
}
// @lc code=end

