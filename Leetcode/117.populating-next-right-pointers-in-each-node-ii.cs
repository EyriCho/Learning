/*
 * @lc app=leetcode id=117 lang=csharp
 *
 * [117] Populating Next Right Pointers in Each Node II
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/
public class Solution {
    public Node Connect(Node root) {
        var node = root;
        while (node != null)
        {
            Node nextStart = null;
            Node nextCur = null;
            while (node != null)
            {
                if (node.left != null || node.right != null)
                {
                    if (nextStart == null)
                    {
                        nextStart = nextCur = node.left ?? node.right;
                    }
                    if (node.left != null && nextCur != node.left)
                    {
                        nextCur.next = node.left;
                        nextCur = node.left;
                    }
                    if (node.right != null && nextCur != node.right)
                    {
                        nextCur.next = node.right;
                        nextCur = node.right;
                    }
                }

                node = node.next;
            }
            
            node = nextStart;
        }

        return root;
    }
}
// @lc code=end

