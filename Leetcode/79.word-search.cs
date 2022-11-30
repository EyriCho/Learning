/*
 * @lc app=leetcode id=79 lang=csharp
 *
 * [79] Word Search
 */

// @lc code=start
public class Solution {
    public bool Exist(char[][] board, string word) {
        var visited = new bool[board.Length, board[0].Length];
        var directions = new int[,] {
            { -1, 0 },
            { 0, -1 },
            { 1, 0 },
            { 0, 1 }
        };
        
        bool Find(int x, int y, int index)
        {
            if (index == word.Length)
            {
                return true;
            }
            
            if (x < 0 || x == board.Length ||
                y < 0 || y == board[0].Length ||
                visited[x, y] ||
                board[x][y] != word[index])
            {
                return false;
            }
            
            visited[x, y] = true;
            
            for (int i = 0; i < 4; i++)
            {
                if (Find(x + directions[i, 0], y + directions[i, 1], index + 1))
                {
                    return true;
                }
            }
            
            visited[x, y] = false;
            
            return false;
        }
        
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == word[0] && Find(i, j, 0))
                {
                    return true;
                }
            }
        }
        
        return false;
    }
}
// @lc code=end

