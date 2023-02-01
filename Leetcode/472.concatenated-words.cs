/*
 * @lc app=leetcode id=472 lang=csharp
 *
 * [472] Concatenated Words
 */

// @lc code=start
public class Solution {
    public IList<string> FindAllConcatenatedWordsInADict(string[] words) {
        var root = new CharNode();

        foreach (var word in words)
        {
            var node = root;

            foreach (var c in word)
            {
                var i = c - 'a';
                if (node.Childs[i] == null)
                {
                    node.Childs[i] = new CharNode();
                }
                node = node.Childs[i];
            }

            node.IsWord = true;
            node.Word = word;
        }

        var result = new List<string>();
        bool dfs(string word, int index, int count)
        {
            if (index == word.Length)
            {
                return count > 1;
            }

            var node = root;
            for (int i = index; i < word.Length; i++)
            {
                var c = word[i] - 'a';
                if (node.Childs[c] == null)
                {
                    return false;
                }
                node = node.Childs[c];
                if (node.IsWord && dfs(word, i + 1, count + 1))
                {
                    return true;
                }
            }
            return false;
        }
        foreach (var word in words)
        {
            if (dfs(word, 0, 0))
            {
                result.Add(word);
            }
        }

        return result;
    }
    
    internal class CharNode
    {
        internal CharNode[] Childs { get; set; }
        internal bool IsWord { get; set; }
        internal string Word { get; set; }
        internal CharNode()
        {
            Childs = new CharNode[26];
        }
    }
}
// @lc code=end

