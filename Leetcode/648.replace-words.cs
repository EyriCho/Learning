/*
 * @lc app=leetcode id=648 lang=csharp
 *
 * [648] Replace Words
 */

// @lc code=start
public class Solution {
    class CharNode
    {
        internal string Word { get; set; }
        internal CharNode[] nexts { get; } = new CharNode[26];
    }

    public string ReplaceWords(IList<string> dictionary, string sentence) {
        CharNode root = new CharNode(),
            node = null;
        int index = 0;
        foreach (string word in dictionary)
        {
            node = root;
            foreach (char c in word)
            {
                index = c - 'a';
                if (node.nexts[index] == null)
                {
                    node.nexts[index] = new CharNode ();
                }
                node = node.nexts[index];
            }

            node.Word = word;
        }

        string[] ss = sentence.Split(' ');
        List<string> list = new ();
        foreach (string s in ss)
        {
            node = root;
            foreach (char c in s)
            {
                node = node.nexts[c - 'a'];
                if (node == null)
                {
                    break;
                }

                if (!string.IsNullOrEmpty(node.Word))
                {
                    list.Add(node.Word);
                    break;
                }
            }

            if (node == null ||
                string.IsNullOrEmpty(node.Word))
            {
                list.Add(s);
            }
        }

        return string.Join(' ', list);
    }
}
// @lc code=end

