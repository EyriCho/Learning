/*
 * @lc app=leetcode id=211 lang=csharp
 *
 * [211] Add and Search Word - Data structure design
 */

// @lc code=start
public class WordDictionary {
    class CharTree
    {
        public bool isWord { get; set; } = false;
        public CharTree[] next { get; } = new CharTree[26];
    }
    
    CharTree root;

    /** Initialize your data structure here. */
    public WordDictionary() {
        root = new CharTree();        
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) {
        var node = root;
        for (int i = 0; i < word.Length; i++)
        {
            int index = word[i] - 'a';
            if (node.next[index] == null)
            {
                node.next[index] = new CharTree();
            }
            node = node.next[index];
        }
        node.isWord = true;        
    }
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word) {
        if (word == null || word.Length == 0)
            return true;
        
        return Search(word, 0, root);        
    }

    private bool Search(string word, int index, CharTree node)
    {
        if (index == word.Length)
            return node.isWord;
        int charIndex = word[index] - 'a';
        if (word[index] != '.')
            return node.next[charIndex] != null &&
                Search(word, index + 1, node.next[charIndex]);
        else
        {
            foreach (var next in node.next)
            {
                if (next != null &&
                   Search(word, index + 1, next))
                    return true;
            }
            return false;
        } 
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
// @lc code=end

