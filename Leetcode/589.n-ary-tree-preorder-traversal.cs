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
        var result = new List<int>();
        if (root == null)
            return result;
        
        var stack = new Stack<Node>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            result.Add(node.val);
            
            if (node.children != null && node.children.Count > 0)
                for (int i = node.children.Count - 1; i > -1; i--)
                    stack.Push(node.children[i]);
        }
        
        return result;
    }
}
// @lc code=end

