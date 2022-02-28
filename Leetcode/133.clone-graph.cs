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
        var dict = new Dictionary<Node, Node>();
        
        Node Dfs(Node n)
        {
            if (n == null)
                return null;
            if (dict.ContainsKey(n))
                return dict[n];
            
            var clone = new Node(n.val);
            dict[n] = clone;
            foreach (var nei in n.neighbors)
            {
                clone.neighbors.Add(Dfs(nei));
            }
            
            return clone;
        }
        
        return Dfs(node);
    }
}
// @lc code=end

