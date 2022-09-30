/*
 * @lc app=leetcode id=429 lang=csharp
 *
 * [429] N-ary Tree Level Order Traversal
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
    public IList<IList<int>> LevelOrder(Node root) {
        var result = new List<IList<int>>();
        if (root == null)
        {
            return result;
        }
        
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var list = new List<int>(queue.Count);
            var c = queue.Count;
            while (c-- > 0)
            {
                var node = queue.Dequeue();
                list.Add(node.val);
                foreach (var child in node.children)
                {
                    queue.Enqueue(child);
                }
            }
            result.Add(list);
        }
        
        return result;
    }
}
// @lc code=end

