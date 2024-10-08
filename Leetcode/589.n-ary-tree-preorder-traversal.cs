/*
 * @lc app=leetcode id=589 lang=csharp
 *
 * [589] N-ary Tree Preorder Traversal
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

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
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
            
            for (int i = node.children.Count - 1; i > -1; i--)
            {
                stack.Push(node.children[i]);
            }
        }
        
        return result;
    }
}
// @lc code=end

