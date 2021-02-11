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
        if (head == null)
            return null;
        
        var node = head;
        while (node != null)
        {
            var n = new Node(node.val);
            n.next = node.next;
            n.random = node.random;
            node.next = n;
            node = n.next;
        }
        
        node = head;
        while (node != null)
        {
            var n = node.next;
            n.random = n.random == null ? null : n.random.next;
            node = n.next;
        }
        
        node = head;
        var result = head.next;
        while (node != null)
        {
            var n = node.next;
            var next = n.next;
            n.next = next == null ? null : next.next;
            node.next = next;
            node = next;
        }
        
        return result;
    }
}
// @lc code=end

