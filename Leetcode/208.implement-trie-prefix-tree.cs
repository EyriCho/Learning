/*
 * @lc app=leetcode id=208 lang=csharp
 *
 * [208] Implement Trie (Prefix Tree)
 */

// @lc code=start
public class Trie {

    public Trie() {
        root = new CharNode();
    }
    
    public void Insert(string word) {
        var node = root;
        
        foreach (var c in word)
        {
            int i = c - 'a';
            if (node.Next[i] == null)
            {
                node.Next[i] = new CharNode();
            }
            node = node.Next[i];
        }
        node.IsWord = true;
    }
    
    public bool Search(string word) {
        var node = root;
        foreach (var c in word)
        {
            int i = c - 'a';
            if (node.Next[i] == null)
            {
                return false;
            }
            node = node.Next[i];
        }
        return node.IsWord;
    }
    
    public bool StartsWith(string prefix) {
        var node = root;
        foreach (var c in prefix)
        {
            int i = c - 'a';
            if (node.Next[i] == null)
            {
                return false;
            }
            node = node.Next[i];
        }
        
        return true;
    }
    
    private CharNode root;
    
    private class CharNode
    {
        internal CharNode[] Next = new CharNode[26];
        internal bool IsWord = false;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
// @lc code=end

