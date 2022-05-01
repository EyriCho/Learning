/*
 * @lc app=leetcode id=705 lang=csharp
 *
 * [705] Design HashSet
 */

// @lc code=start
public class MyHashSet {

    /** Initialize your data structure here. */
    public MyHashSet() {
        bucket = new int[1000][];
    }

    int[][] buckets;
    
    public void Add(int key) {
        var hashKey = key % 1000;
        if (bucket[hashKey] == null)
        {
            bucket[hashKey] = new int[1001];
        }
        bucket[hashKey][key / 1000] = 1;
    }
    
    public void Remove(int key) {
        var hashKey = key % 1000;
        if (bucket[hashKey] != null)
        {
            bucket[hashKey][key / 1000] = 0;
        }
    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        var hashKey = key % 1000;
        if (bucket[hashKey] == null)
        {
            return false;
        }
        return bucket[hashKey][key / 1000] == 1;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
// @lc code=end

