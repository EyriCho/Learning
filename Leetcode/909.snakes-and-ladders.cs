/*
 * @lc app=leetcode id=909 lang=csharp
 *
 * [909] Snakes and Ladders
 */

// @lc code=start
public class Solution {
    public int SnakesAndLadders(int[][] board) {
        (int, int) Locate(int num)
        {
            num--;
            var x = board.Length - num / board.Length - 1;

            if (((num / board.Length) & 1) == 0)
            {
                return (x, num % board.Length);
            }
            else
            {
                return (x, board.Length - 1 - num % board.Length);
            }
        }

        var queue = new Queue<int>();
        queue.Enqueue(1);
        var move = 0;
        var target = board.Length * board.Length;
        var visited = new bool[target + 1];
        visited[1] = true;

        while (queue.Count > 0)
        {
            move++;
            var count = queue.Count;
            while (count-- > 0)
            {
                var pos = queue.Dequeue();

                for (int i = 1; i <= 6; i++)
                {
                    var next = pos + i;
                    if (next == target)
                    {
                        return move;
                    }
                    else if (next > target)
                    {
                        break;
                    }

                    var (x, y) = Locate(next);
                    if (board[x][y] != -1)
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

