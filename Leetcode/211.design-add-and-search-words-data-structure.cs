/*
 * @lc app=leetcode id=211 lang=csharp
 *
 * [211] Design Add and Search Words Data Structure
 */

// @lc code=start
public class WordDictionary {

    internal class ChareNode
    {
        internal bool IsWord { get; set; }
        internal ChareNode[] Next { get; set; }
        
        internal ChareNode() 
        {
            IsWord = false;
            Next = new ChareNode[26];
        }
    }
    
    ChareNode root;

    public WordDictionary() {
        root = new ChareNode();
    }
    
    public void AddWord(string word) {
        var node = root;
        foreach (var c in word)
        {
            int i = c - 'a';
            if (node.Next[i] == null)
            {
                node.Next[i] = new ChareNode();
            }
            node = node.Next[i];
        }
        
        node.IsWord = true;
    }
    
    public bool Search(string word) {
        bool SearchWord(int i, ChareNode node)
        {
            if (i == word.Length)
            {
                return node.IsWord;
            }
            
            if (word[i] == '.')
            {
                foreach (var n in node.Next)
                {
                    if (n != null &&
                        SearchWord(i + 1, n))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return (node.Next[word[i] - 'a'] != null &&
                    SearchWord(i + 1, node.Next[word[i] - 'a']));
            }
        }
        
        return SearchWord(0, root);
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
// @lc code=end

