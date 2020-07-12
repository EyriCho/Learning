/*
 * @lc app=leetcode id=116 lang=csharp
 *
 * [116] Populating Next Right Pointers in Each Node
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
            var cur = node;
            while (cur != null)
            {
                if (cur.left != null)
                {
                    cur.left.next = cur.right;
                    if (cur.next != null)
                        cur.right.next = cur.next.left;
                }
                cur = cur.next;
            }
            node = node.left;
        }
        return root;
    }
}
// @lc code=end

