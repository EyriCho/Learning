/*
 * @lc app=leetcode id=133 lang=csharp
 *
 * [133] Clone Graph
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;
    
    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }
    
    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        var dict = new Dictionary<int, Node>();
        return Clone(node, dict);
    }
    
    private Node Clone(Node node, Dictionary<int, Node> dict)
    {
        if (node == null)
            return null;
        
        if (dict.ContainsKey(node.val))
            return dict[node.val];
        var newNode = new Node(node.val);
        dict[node.val] = newNode;
        foreach (var neighbor in node.neighbors)
        {
            newNode.neighbors.Add(Clone(neighbor, dict));
        }
        return newNode;
    }}
// @lc code=end

