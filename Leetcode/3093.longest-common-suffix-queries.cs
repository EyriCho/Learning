/*
 * @lc app=leetcode id=3093 lang=csharp
 *
 * [3093] Longest Common Suffix Queries
 */

// @lc code=start
public class Solution {
    internal class Trie
    {
        internal Trie[] Next;

        internal int Index;

        internal Trie()
        {
            Next = new Trie[26];
        }
    }

    public int[] StringIndices(string[] wordsContainer, string[] wordsQuery) {
        Trie root = new (),
            node = null;
        
        int idx = 0;
        for (int i = 0; i < wordsContainer.Length; i++)
        {
            node = root;

            if (wordsContainer[i].Length <
                wordsContainer[node.Index].Length)
            {
                node.Index = i;
            }

            for (int w = wordsContainer[i].Length - 1; w >= 0; w--)
            {
                idx = wordsContainer[i][w] - 'a';
                if (node.Next[idx] == null)
                {
                    node.Next[idx] = new Trie() {
                        Index = i,
                    };
                }

                node = node.Next[idx];

                if (wordsContainer[i].Length <
                    wordsContainer[node.Index].Length)
                {
                    node.Index = i;
                }
            }
        }

        int[] result = new int[wordsQuery.Length];
        for (int q = 0; q < wordsQuery.Length; q++)
        {
            node = root;

            for (int w = wordsQuery[q].Length - 1; w >= 0; w--)
            {
                idx = wordsQuery[q][w] - 'a';
                if (node.Next[idx] == null)
                {
                    break;
                }

                node = node.Next[idx];
            }

            result[q] = node.Index;
        }

        return result;
    }
}
// @lc code=end

