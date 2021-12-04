/*
 * @lc app=leetcode id=212 lang=csharp
 *
 * [212] Word Search II
 */

// @lc code=start
public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        var result = new List<string>(words.Length);
        var root = new CharNode();
        
        var directions = new int[,] {
            { -1, 0 },
            { 0, -1 },
            { 1, 0 },
            { 0, 1 }
        };
        
        foreach (var word in words)
        {
            var node = root;
            foreach (var c in word)
            {
                int i = c - 'a';
                if (node.Next[i] == null)
                    node.Next[i] = new CharNode();
                node = node.Next[i];
            }
            node.Word = word;
        }
        
        
        void Find(CharNode node, int x, int y)
        {
            if (node.Word != string.Empty)
            {
                result.Add(node.Word);
                node.Word = string.Empty;
            }
            
            if (x < 0 || x == board.Length ||
                y < 0 || y == board[0].Length ||
                board[x][y] == '#')
                return;
            
            var index = board[x][y] - 'a';
            if (node.Next[index] == null)
                return;
            
            node = node.Next[index];
            
            board[x][y] = '#';
            for (int i = 0; i < 4; i++)
                Find(node, x + directions[i, 0], y + directions[i, 1]);
            board[x][y] = (char)('a' + index);
        }
        
        for (int i = 0; i < board.Length; i++)
            for (int j = 0; j < board[0].Length; j++)
            {
                int index = board[i][j] - 'a';
                if (root.Next[index] != null)
                    Find(root, i, j);
            }
        
        return result;        
    }
    
    internal class CharNode
    {
        internal string Word = string.Empty;
        internal CharNode[] Next = new CharNode[26];
    }
}
// @lc code=end

