/*
 * @lc app=leetcode id=820 lang=csharp
 *
 * [820] Short Encoding of Words
 */

// @lc code=start
public class Solution {
    public int MinimumLengthEncoding(string[] words) {
        int result = 0;
        var root = new WordTree(false);
        
        foreach (var w in words)
        {
            var node = root;
            int index = 0;
            for (int i = w.Length - 1; i >= 0; i--)
            {
                if (node.IsWord)
                {
                    node.IsWord = false;
                    result -= w.Length - i;
                }
                index = w[i] - 'a';
                if (node.Next[index] == null)
                {
                    node.Next[index] = new WordTree(i == 0);
                    if (i == 0)
                        result += w.Length + 1;
                }
                node = node.Next[index];
            }
        }
        
        return result;
    }
    
    internal class WordTree
    {
        internal bool IsWord;
        internal WordTree[] Next;
        
        internal WordTree(bool isWord)
        {
            IsWord = isWord;
            Next = new WordTree[26];
        }
    }
}
// @lc code=end

