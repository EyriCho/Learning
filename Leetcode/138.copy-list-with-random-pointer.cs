/*
 * @lc app=leetcode id=138 lang=csharp
 *
 * [138] Copy List with Random Pointer
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        var dict = new Dictionary<Node, Node>();

        Node Copy(Node node)
        {
            if (node == null)
            {
                return null;
            }

            if (dict.ContainsKey(node))
            {
                return dict[node];
            }

            var rst = new Node(node.val);
            dict[node] = rst;
            rst.next = Copy(node.next);
            rst.random = Copy(node.random);

            return rst;
        }

        return Copy(head);
    }
}
// @lc code=end

