/*
 * @lc app=leetcode id=745 lang=csharp
 *
 * [745] Prefix and Suffix Search
 */

// @lc code=start
public class WordFilter {

    public WordFilter(string[] words) {
        prefTree = new CharNode();
        suffTree = new CharNode();
        for (int i = 0; i < words.Length; i++)
        {
            var word = words[i];
            CharNode prefNode = prefTree, suffNode = suffTree;
            for (int j = 0; j < word.Length; j++)
            {
                var pref = word[j] - 'a';
                var suff = word[word.Length - 1 - j] - 'a';
                if (prefNode.Next[pref] == null)
                    prefNode.Next[pref] = new CharNode();
                prefNode = prefNode.Next[pref];
                prefNode.Indexes.Add(i);
                if (suffNode.Next[suff] == null)
                    suffNode.Next[suff] = new CharNode();
                suffNode = suffNode.Next[suff];
                suffNode.Indexes.Add(i);
            }
        }
    }
    
    CharNode prefTree;
    CharNode suffTree;
    
    class CharNode
    {
        internal CharNode()
        {
            Next = new CharNode[26];
            Indexes = new List<int>();
        }
        
        internal CharNode[] Next { get; set; }
        internal IList<int> Indexes { get; set; }
    }
    
    public int F(string prefix, string suffix) {
        CharNode prefNode = prefTree, suffNode = suffTree;
        foreach (var c in prefix)
        {
            if (prefNode.Next[c - 'a'] == null)
                return -1;
            prefNode = prefNode.Next[c - 'a'];
        }
        for (int i = suffix.Length - 1; i > -1; i--)
        {
            if (suffNode.Next[suffix[i] - 'a'] == null)
                return -1;
            suffNode = suffNode.Next[suffix[i] - 'a'];
        }
                
        int p = prefNode.Indexes.Count - 1,
            s = suffNode.Indexes.Count - 1;
        while (p >= 0 && s >= 0)
        {
            if (prefNode.Indexes[p] > suffNode.Indexes[s])
                p--;
            else if (prefNode.Indexes[p] < suffNode.Indexes[s])
                s--;
            else
                return prefNode.Indexes[p];
        }
        return -1;
    }
}

/**
 * Your WordFilter object will be instantiated and called as such:
 * WordFilter obj = new WordFilter(words);
 * int param_1 = obj.F(prefix,suffix);
 */
// @lc code=end

