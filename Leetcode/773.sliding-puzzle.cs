/*
 * @lc app=leetcode id=773 lang=csharp
 *
 * [773] Sliding Puzzle
 */

// @lc code=start
public class Solution {
    public int SlidingPuzzle(int[][] board) {
        int target = 123_450,
            current = board[0][0] * 100_000 + board[0][1] * 10_000 + board[0][2] * 1_000 +
            board[1][0] * 100 + board[1][1] * 10 + board[1][2],
            next = 0,
            zero = 0,
            count = 0,
            step = 0;

        int LocateZero(int number)
        {
            int rst = 0;
            while (number > 0)
            {
                if (number % 10 == 0)
                {
                    return rst;
                }
                number /= 10;
                rst++;
            }

            return rst;
        }

        int[][] transit = new int[][] {
            new int[] { 1_000, 10 },
            new int[] { 10_000, 100, 1 },
            new int[] { 100_000, 10 },
            new int[] { 10_000, 1 },
            new int[] { 100_000, 1_000, 10 },
            new int[] { 10_000, 100 },
        };

        int Swap(int num, int z, int p)
        {
            int d = num / p % 10;
            return num - p * d + (int)Math.Pow(10, z) * d;
        }

        HashSet<int> set = new();
        set.Add(current);
        Queue<int> queue = new ();
        queue.Enqueue(current);
        while (queue.Count > 0)
        {
            count = queue.Count;
            while (count-- > 0)
            {
                current = queue.Dequeue();
                if (current == target)
                {
                    return step;
                }

                zero = LocateZero(current);

                foreach (int pos in transit[zero])
                {
                    next = Swap(current, zero, pos);
                    if (set.Contains(next))
                    {
                        continue;
                    }

                    queue.Enqueue(next);
                    set.Add(next);
                }
            }

            step++;
        }

        return -1;
    }
}
// @lc code=end

