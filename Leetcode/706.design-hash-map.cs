/*
 * @lc app=leetcode id=706 lang=csharp
 *
 * [706] Design HashMap
 */

// @lc code=start
public class MyHashMap {

    /** Initialize your data structure here. */
    public MyHashMap() {
        buckets = new ListNode[10_000];
    }
    
    /** value will always be non-negative. */
    public void Put(int key, int value) {
        int pos = key % buckets.Length;
        var node = buckets[pos];
        while (node != null && node.Key != key)
            node = node.Next;
        
        if (node == null)
        {
            var newNode = new ListNode(key, value);
            newNode.Next = buckets[pos];
            buckets[pos] = newNode;
        }
        else 
            node.Val = value;
    }
    
    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key) {
        int pos = key % buckets.Length;
        var node = buckets[pos];
        while (node != null && node.Key != key)
            node = node.Next;
        
        return node?.Val ?? -1;
    }
    
    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key) {
        int pos = key % buckets.Length;
        ListNode node = buckets[pos], prev = null;
        while (node != null && node.Key != key)
        {
            prev = node;
            node = node.Next;
        }
        
        if (node != null)
            if (prev == null)
                buckets[pos] = node?.Next;
            else
                prev.Next = node?.Next;
    }
    
    ListNode[] buckets;
    
    internal class ListNode
    {
        internal int Key;
        internal int Val;
        internal ListNode Next;
        
        internal ListNode (int key, int val)
        {
            Key = key;
            Val = val;
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
// @lc code=end

