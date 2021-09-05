/*
 * @lc app=leetcode id=677 lang=csharp
 *
 * [677] Map Sum Pairs
 */

// @lc code=start
public class MapSum {

    /** Initialize your data structure here. */
    public MapSum() {
        root = new WordTree();
        dict = new Dictionary<string, int>();
    }
    
    private WordTree root;
    private Dictionary<string, int> dict;
    
    public void Insert(string key, int val) {
        var node = root;
        var adjustVal = dict.ContainsKey(key) ? (val - dict[key]) : val;
        foreach (var c in key)
        {
            var i = c - 'a';
            if (node.next[i] == null)
                node.next[i] = new WordTree(val);
            else
                node.next[i].count += adjustVal;
            node = node.next[i];
        }
        dict[key] = val;
    }
    
    public int Sum(string prefix) {
        var node = root;
        foreach (var c in prefix)
        {
            var i = c - 'a';
            if (node.next[i] == null)
                return 0;
            else
                node = node.next[i];
        }
        
        return node.count;
    }
    
    internal class WordTree {
        internal WordTree[] next;
        internal int count;
        
        internal WordTree(int count = 0)
        {
            this.count = count;
            next = new WordTree[26];
        }
    }
}

/**
 * Your MapSum object will be instantiated and called as such:
 * MapSum obj = new MapSum();
 * obj.Insert(key,val);
 * int param_2 = obj.Sum(prefix);
 */
// @lc code=end

