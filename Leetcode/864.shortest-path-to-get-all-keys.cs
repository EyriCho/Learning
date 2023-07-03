/*
 * @lc app=leetcode id=864 lang=csharp
 *
 * [864] Shortest Path to Get All Keys
 */

// @lc code=start
public class Solution {
    public int ShortestPathAllKeys(string[] grid) {
        var queue = new Queue<(int, int, int)>();
        var set = new HashSet<string>();
        var keyCount = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '@')
                {
                    queue.Enqueue((i, j, 0));
                    set.Add($"{i * 30 + j}-0");
                }
                else if (grid[i][j] >= 'a' && grid[i][j] <= 'z')
                {
                    keyCount++;
                }
            }
        }

        var directions = new int[,] {
            { 1, 0 },
            { 0, 1 },
            { -1, 0 },
            { 0, -1 },
        };

        var allKeys = (1 << keyCount) - 1;
        var step = 1;
        while (queue.Count > 0)
        {
            var c = queue.Count;
            while (c-- > 0)
            {
                var (x, y, currentKeys) = queue.Dequeue();
                
                for (int d = 0; d < 4; d++)
                {
                    int i = x + directions[d, 0],
                        j = y + directions[d, 1],
                        keys = currentKeys;

                    if (i < 0 || i >= grid.Length ||
                        j < 0 || j >= grid[i].Length)
                    {
                        continue;
                    }

                    if (grid[i][j] == '#')
                    {
                        continue;
                    }
                    else if (grid[i][j] >= 'A' && grid[i][j] <= 'Z' &&
                        ((keys >> grid[i][j] - 'A') & 1) == 0)
                    {
                        continue;
                    }
                    else if (grid[i][j] >= 'a' && grid[i][j] <= 'z')
                    {
                        keys |= (1 << (grid[i][j] - 'a'));
                    }

                    if (keys == allKeys)
                    {
                        return step;
                    }

                    var hash = $"{i * 30 + j}-{keys}";
                    if (!set.Contains(hash))
                    {
                        set.Add(hash);
                        queue.Enqueue((i, j, keys));
                    }
                }
            }

            step++;
        }

        return -1;
    }
}
// @lc code=end

