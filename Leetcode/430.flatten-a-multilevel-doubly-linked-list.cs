/*
 * @lc app=leetcode id=430 lang=csharp
 *
 * [430] Flatten a Multilevel Doubly Linked List
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head) {
        var node = head;
        var stack = new Stack<Node>();  
        while (node != null)
        {
            if (node.child != null)
            {
                if (node.next != null)
                    stack.Push(node.next);
                node.next = node.child;
                node.next.prev = node;
                node.child = null;
            }
            else if (node.next == null && stack.Count > 0)
            {
                Node next = stack.Pop();
                node.next = next;
                next.prev = node;
            }
            
            node = node.next;
        }
        
        return head;        
    }
}
// @lc code=end

