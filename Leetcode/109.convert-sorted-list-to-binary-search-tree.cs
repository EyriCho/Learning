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
            return null;
        
        TreeNode BST(ListNode root)
        {
            ListNode prev = null,
                node = root,
                fast = root;
            
            while (fast.next != null && fast.next.next != null)
            {
                prev = node;
                node = node.next;
                fast = fast.next.next;
            }
            
            var treeNode = new TreeNode(node.val);
            
            if (prev != null)
            {
                prev.next = null;
                treeNode.left = BST(root);
            }
                
            if (node.next != null)
                treeNode.right = BST(node.next);
            
            return treeNode;
        }
        
        return BST(head);
    }
}
// @lc code=end

