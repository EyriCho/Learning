/*
 * @lc app=leetcode id=2416 lang=csharp
 *
 * [2416] Sum of Prefix Scores of Strings
 */

// @lc code=start
public class Solution {
    internal class CharNode
    {
        internal CharNode[] Nexts;
        internal int Count;

        internal CharNode()
        {
            Nexts = new CharNode[26];
            Count = 0;
        }
    }

    public int[] SumPrefixScores(string[] words) {
        CharNode root = new CharNode(),
            node = null;
        int index = 0,
            sum = 0;;

        foreach (string word in words)
        {
            node = root;
            foreach (char c in word)
            {
                index = c - 'a';
                if (node.Nexts[index] == null)
                {
                    node.Nexts[index] = new CharNode();
                }
                node = node.Nexts[index];
                node.Count++;
            }
        }

        int[] result = new int[words.Length];
        for (int i = 0; i < words.Length; i++)
        {
            node = root;
            sum = 0;
            foreach (char c in words[i])
            {
                index = c - 'a';
                node = node.Nexts[index];
                sum += node.Count;
            }
            result[i] = sum;
        }
        return result;
    }
}
// @lc code=end

