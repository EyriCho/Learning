/*
 * @lc app=leetcode id=1032 lang=csharp
 *
 * [1032] Stream of Characters
 */

// @lc code=start
public class StreamChecker {
    List<int> list;
    CharTree root;
    
    class CharTree
    {
        public CharTree[] prev;
        public bool isWord;
        
        public CharTree()
        {
            prev = new CharTree[26];
            isWord = false;
        }
    }

    public StreamChecker(string[] words) {
        root = new CharTree();
        list = new List<int>();
        
        foreach (string word in words)
        {
            var node = root;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                var index = word[i] - 'a';
                if (node.prev[index] == null)
                    node.prev[index] = new CharTree();
                node = node.prev[index];
            }
            node.isWord = true;
        }
    }
    
    public bool Query(char letter) {
        var node = root;
        list.Add(letter);
        for (int i = list.Count() - 1; i >= 0; i--)
        {
            var index = list[i] - 'a';
            if (node.prev[index] == null)
                return false;
            node = node.prev[index];
            if (node.isWord)
                return true;
        }
        
        return false;
    }
}

/**
 * Your StreamChecker object will be instantiated and called as such:
 * StreamChecker obj = new StreamChecker(words);
 * bool param_1 = obj.Query(letter);
 */
// @lc code=end

