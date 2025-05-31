/*
 * @lc app=leetcode id=909 lang=csharp
 *
 * [909] Snakes and Ladders
 */

// @lc code=start
public class Solution {
    public int SnakesAndLadders(int[][] board) {
        (int, int) Locate(int position)
        {
            position--;

            int x = board.Length - 1 - position / board.Length;
            if (((position / board.Length) & 1) == 0)
            {
                return (x, position % board.Length);
            }
            else
            {
                return (x, board.Length - 1 - position % board.Length);
            }
        }

        int pos = 0, x = 0, y = 0, next = 0,
            target = board.Length * board.Length,
            count = 0,
            move = 0;
        Queue<int> queue = new ();
        queue.Enqueue(1);
        bool[] visited = new bool[target + 1];
        visited[1] = true;

        while (queue.Count > 0)
        {
            move++;
            count = queue.Count;
            while (count-- > 0)
            {
                pos = queue.Dequeue();
                
                for (int i = 1; i <= 6; i++)
                {
                    next = pos + i;
                    if (next == target)
                    {
                        return move;
                    }
                    else if (next > target)
                    {
                        break;
                    }

                    (x, y) = Locate(next);
                    if (board[x][y] > 0)
                    {
                        if (board[x][y] == target)
                        {
                            return move;
                        }

                        next = board[x][y];
                    }

                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }

        return -1;
    }
}
// @lc code=end

