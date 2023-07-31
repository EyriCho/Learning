/*
 * @lc app=leetcode id=146 lang=csharp
 *
 * [146] LRU Cache
 */

// @lc code=start
public class LRUCache {

    internal class LinkedNode {
        internal LinkedNode prev;
        internal LinkedNode next;
        internal int key;
        internal int val;
    }

    private LinkedNode head;
    private LinkedNode tail;
    int capacity;
    Dictionary<int, LinkedNode> dict;

    public LRUCache(int capacity) {
        head = new LinkedNode();
        tail = new LinkedNode();
        head.next = tail;
        tail.prev = head;
        this.capacity = capacity;
        dict = new Dictionary<int, LinkedNode>();
    }
    
    public int Get(int key) {
        if (!dict.TryGetValue(key, out LinkedNode node))
        {
            return -1;
        }

        node.prev.next = node.next;
        node.next.prev = node.prev;

        head.next.prev = node;
        node.next = head.next;
        head.next = node;
        node.prev = head;

        return node.val;
    }
    
    public void Put(int key, int value) {
        if (dict.TryGetValue(key, out LinkedNode node))
        {
            node.val = value;
            node.prev.next = node.next;
            node.next.prev = node.prev;
        }
        else
        {
            dict[key] = node = new LinkedNode() {
                key = key,
                val = value,
            };
        }

        head.next.prev = node;
        node.next = head.next;
        head.next = node;
        node.prev = head;

        if (dict.Count > capacity)
        {
            var remove = tail.prev;
            dict.Remove(remove.key);
            remove.prev.next = tail;
            tail.prev = remove.prev;
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

