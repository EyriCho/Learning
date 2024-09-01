/*
 * @lc app=leetcode id=590 lang=csharp
 *
 * [590] N-ary Tree Postorder Traversal
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Postorder(Node root) {
        List<int> result = new ();
        if (root == null)
        {
            return result;
        }
        Stack<Node> stack = new ();
        stack.Push(root);
        Node node;
        while (stack.Count > 0)
        {
            node = stack.Pop();
            result.Add(node.val);

            foreach (Node child in node.children)
            {
                stack.Push(child);
            }
        }

        int l = 0,
            r = result.Count - 1;
        while (l < r)
        {
            result[l] ^= result[r];
            result[r] ^= result[l];
            result[l++] ^= result[r--];
        }
        return result;
    }
}
// @lc code=end

